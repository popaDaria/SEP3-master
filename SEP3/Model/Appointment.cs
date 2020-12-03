using System;
using System.Collections.Generic;

namespace SEP3.Model
{
    public class Appointment
        {
            public string Subject { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
            public int patientID { get; set; }
            public int doctorID { get; set; }
        }
}