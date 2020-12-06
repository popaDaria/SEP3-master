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
    public class CloudHospitalService : ICloudHospitalService
    {
        public async Task AddHospital(Hospital hospital)
        {
            hospital.validated = false;
            HttpClient client = new HttpClient();
            string usersSerialized = JsonSerializer.Serialize(hospital);
            StringContent content = new StringContent(
                usersSerialized,
                Encoding.UTF8,
                "application/json"
            );
            
            //Console.WriteLine(usersSerialized);
            HttpResponseMessage responseMessage =
                await client.PostAsync("https://localhost:8085/hospitals", content);
            Console.WriteLine(responseMessage.StatusCode); 
        }

        public async Task<Hospital> GetHospital(int idNr)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage message = await client.GetAsync("https://localhost:8085/hospitals?id="+idNr);
            string content = await message.Content.ReadAsStringAsync();
            Console.WriteLine(message.Content.ReadAsStringAsync().Result);
            Hospital result = JsonConvert.DeserializeObject<Hospital>(content);
            
            
            return result;
        }

        public async Task<List<Hospital>> GetAllHospitals()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage message = await client.GetAsync("https://localhost:8085/hospitals/all");
            string content = await message.Content.ReadAsStringAsync();
            Console.WriteLine(content);
            List<Hospital> result = JsonConvert.DeserializeObject<List<Hospital>>(content);
            return result;
        }

        public async Task EditHospital(Hospital Hospital)
        {
            HttpClient client = new HttpClient();
            string usersSerialized = JsonSerializer.Serialize(Hospital);
            StringContent content = new StringContent(
                usersSerialized,
                Encoding.UTF8,
                "application/json"
            );
            HttpResponseMessage message = await client.PatchAsync("https://localhost:8085/hospitals", content);
            Console.WriteLine(message.StatusCode);
        }

        public async Task<List<string>> GetAllDepartments(int hosId)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage message = await client.GetAsync("https://localhost:8085/hospitals/departments?id="+hosId);
            string content = await message.Content.ReadAsStringAsync();
            //Console.WriteLine(content);
            List<string> result = JsonConvert.DeserializeObject<List<string>>(content);
            return result;
        }

        public async Task<List<Hospital>> GetAllHospitalsValidated()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage message = await client.GetAsync("https://localhost:8085/hospitals/validated");
            string content = await message.Content.ReadAsStringAsync();
            //Console.WriteLine(content);
            List<Hospital> result = JsonConvert.DeserializeObject<List<Hospital>>(content);
            return result;
        }
        
        public async Task<List<Hospital>> GetAllHospitalsInvalid()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage message = await client.GetAsync("https://localhost:8085/hospitals/invalid");
            string content = await message.Content.ReadAsStringAsync();
            //Console.WriteLine(content);
            List<Hospital> result = JsonConvert.DeserializeObject<List<Hospital>>(content);
            return result;
        }

        public async Task<List<Hospital>> GetAllHospitalsForManager(int id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage message = await client.GetAsync("https://localhost:8085/hospitals/manager?id="+id);
            string content = await message.Content.ReadAsStringAsync();
            //Console.WriteLine(content);
            List<Hospital> result = JsonConvert.DeserializeObject<List<Hospital>>(content);
            return result;
        }

        public async Task ValidateHospital(int id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage message = await client.GetAsync("https://localhost:8085/hospitals/validate?id="+id);
            Console.WriteLine(message);
        }
        
        public async Task RemoveHospital(int id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage message = await client.DeleteAsync("https://localhost:8085/hospitals/"+id);
            Console.WriteLine(message);
        }
    }
}