using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SEP3.Model;

namespace SEP3.Data
{
    public class CloudMessageService : ICloudMessageService
    {
        public async Task<List<Message>> GetMessagesToMe(int idNr)
        {
            HttpClient client = new HttpClient();
            string message = await client.GetStringAsync("https://localhost:8085/messages?userId="+idNr);
            Console.WriteLine(message);
            List<Message> result = JsonSerializer.Deserialize<List<Message>>(message);
            return result;        
        }
        
        public async Task<List<Message>> GetMessagesFromToAndToFrom(int me, int someone)
        {
            HttpClient client = new HttpClient();
            string message = await client.GetStringAsync("https://localhost:8085/messages/sentTo?senderId="+me+"&receiverId="+someone);
            Console.WriteLine(message);
            List<Message> result = JsonSerializer.Deserialize<List<Message>>(message);
            return result;        
        }
        
        public async Task SendMessage(Message message)
        {
            HttpClient client = new HttpClient();
            string usersSerialized = JsonSerializer.Serialize(message);
            StringContent content = new StringContent(
                usersSerialized,
                Encoding.UTF8,
                "application/json"
            );
            
            HttpResponseMessage responseMessage =
                await client.PostAsync("https://localhost:8085/messages", content);
            Console.WriteLine(responseMessage.StatusCode); 
        }
    }
}