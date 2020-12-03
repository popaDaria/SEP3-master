using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SEP3.Model;

namespace SEP3.Data
{
    public class CloudAppointmentService : ICloudAppointmentService
    {
        public async Task<List<Appointment>> GetAllForPatient(int id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage message = await client.GetAsync("https://localhost:8085/appointments/patient/"+id);
            string content = await message.Content.ReadAsStringAsync();
            Console.WriteLine(content);
            List<Appointment> result = JsonConvert.DeserializeObject<List<Appointment>>(content);
            return result;
        }
        
        public async Task<List<Appointment>> GetAllForDoctor(int id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage message = await client.GetAsync("https://localhost:8085/appointments/doctor/"+id);
            string content = await message.Content.ReadAsStringAsync();
            Console.WriteLine(content);
            List<Appointment> result = JsonConvert.DeserializeObject<List<Appointment>>(content);
            return result;
        }
    }
}