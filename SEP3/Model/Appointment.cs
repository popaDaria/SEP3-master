using System;
using System.Text.Json.Serialization;

namespace SEP3.Model
{
    public class Appointment
    {
        public int patientId { get; set; }
        public int doctorId { get; set; }
        [JsonPropertyName("startTime")]
        public DateTime startTime { get; set; }
        [JsonPropertyName("endTime")]
        public DateTime endTime { get; set; }
        [JsonPropertyName("summary")]
        public string summary { get; set; }
        [JsonPropertyName("id")]
        public int id { get; set; }
    }
}