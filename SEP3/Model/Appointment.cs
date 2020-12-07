using System;

namespace SEP3.Model
{
    public class Appointment
    {
        public int patientId { get; set; }
        public int doctorId { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public string summary { get; set; }
    }
}