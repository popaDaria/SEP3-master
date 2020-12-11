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
    public class CloudMedicalRecordService : ICloudMedicalRecordService
    {
        public async Task AddMedicalRecord(MedicalRecord medicalRecord)
        {
            HttpClient client = new HttpClient();
            string ratingSerialized = JsonSerializer.Serialize(medicalRecord);
            StringContent content = new StringContent(
                ratingSerialized,
                Encoding.UTF8,
                "application/json"
            );
            HttpResponseMessage responseMessage =
                await client.PostAsync("https://localhost:8085/records", content);
            Console.WriteLine(responseMessage.StatusCode);
        }

        public async Task<MedicalRecord> GetMedicalRecord(int patientId)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage message = await client.GetAsync("https://localhost:8085/records/"+patientId);
            string content = await message.Content.ReadAsStringAsync();
            Console.WriteLine(content);
            MedicalRecord result = JsonConvert.DeserializeObject<MedicalRecord>(content);
            return result;         
        }

        public async Task EditMedicalRecord(MedicalRecord medicalRecord)
        {
            HttpClient client = new HttpClient();
            string usersSerialized = JsonSerializer.Serialize(medicalRecord);
            StringContent content = new StringContent(
                usersSerialized,
                Encoding.UTF8,
                "application/json"
            );
            HttpResponseMessage message = await client.PatchAsync("https://localhost:8085/records", content);
            Console.WriteLine(message.StatusCode);
        }
    }
}