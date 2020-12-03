using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using SEP3.Model;

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
    }
}
