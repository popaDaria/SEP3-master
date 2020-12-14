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
    public class CloudDoctorHospitalService : ICloudDoctorHospitalService
    {
        public async Task AddDoctorHospital(DoctorHospital doctorHospital)
        {
            HttpClient httpClient = new HttpClient();
            string docHos = JsonSerializer.Serialize(doctorHospital);
            StringContent content = new StringContent(
                docHos,
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage responseMessage =
                await httpClient.PostAsync("https://localhost:8085/hospitalDoctor", content);
            Console.WriteLine(responseMessage.StatusCode); 
        }

        public async Task<IList<User>> GetAllDoctorsForDepartment(int hosId, string deptString)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage message = await client.GetAsync("https://localhost:8085/hospitalDoctor/doctors?hosId="+hosId+"&&dept="+deptString);
            string content = await message.Content.ReadAsStringAsync();
            //Console.WriteLine(content);
            List<User> result = JsonConvert.DeserializeObject<List<User>>(content);
            return result;
        }
    }
}
