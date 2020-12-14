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
    public class CloudRatingService : ICloudRatingService
    {
        public async Task AddRating(Rating rating)
        {
            HttpClient client = new HttpClient();
            string ratingSerialized = JsonSerializer.Serialize(rating);
            StringContent content = new StringContent(
                ratingSerialized,
                Encoding.UTF8,
                "application/json"
            );
            HttpResponseMessage responseMessage =
                await client.PostAsync("https://localhost:8085/ratings", content);
            Console.WriteLine(responseMessage.StatusCode);
            
        }

        public async Task<List<Rating>> GetAllForHospital(int hospitalId)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage message = await client.GetAsync("https://localhost:8085/ratings?hospitalId="+hospitalId);
            string content = await message.Content.ReadAsStringAsync();
            Console.WriteLine(content);
            List<Rating> result = JsonConvert.DeserializeObject<List<Rating>>(content);
            return result;        
        }
    }
}