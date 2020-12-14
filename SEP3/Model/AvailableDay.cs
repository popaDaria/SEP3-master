using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace SEP3.Model
{
    public class AvailableDay
    {
        [JsonPropertyName("doctorId")]
        public int DoctorId { get; set; }
        [JsonPropertyName("availableDate")]
        public DateTime AvailableDate { get; set; }
        [JsonPropertyName("startTime")]
        public DateTime StartTime { get; set; }
        [JsonPropertyName("endTime")]
        public DateTime EndTime { get; set; }
        [JsonPropertyName("appointmentNr")]
        public int AppointmentNr { get; set; }
    }
}