using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SEP3.Model;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace SEP3.Data
{
    public class CloudAvailableDayService : ICloudAvailableDayService
    {
        public async Task<List<AvailableDay>> GetAvailableDays(int doctorId)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage message = await client.GetAsync("https://localhost:8085/availableDays/"+doctorId);
            string content = await message.Content.ReadAsStringAsync();
            Console.WriteLine(content);
            List<AvailableDay> result = JsonConvert.DeserializeObject<List<AvailableDay>>(content);
            return result;        
        }

        public async Task AddAvailableDay(AvailableDay availableDay)
        {
            HttpClient httpClient = new HttpClient();
            string appt = JsonSerializer.Serialize(availableDay);
            StringContent content = new StringContent(
                appt,
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage responseMessage =
                await httpClient.PostAsync("https://localhost:8085/availableDays", content);
            Console.WriteLine(responseMessage.StatusCode);         }

        public async Task UpdateAvailableDay(AvailableDay availableDay)
        {
            HttpClient client = new HttpClient();
            string usersSerialized = JsonSerializer.Serialize(availableDay);
            StringContent content = new StringContent(
                usersSerialized,
                Encoding.UTF8,
                "application/json"
            );
            HttpResponseMessage message = await client.PatchAsync("https://localhost:8085/availableDays", content);
            Console.WriteLine(message.StatusCode);
        }
    }
}