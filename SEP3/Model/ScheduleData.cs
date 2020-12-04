using System;
using System.Collections.Generic;

namespace SEP3.Model
{
    public class ScheduleData
    {
        public List<DoctorsEventData> data = new List<DoctorsEventData>();
        public class DoctorsEventData
        {
            public int Id { get; set; }
            public string Subject { get; set; }
            public string EventType { get; set; }
            public string Description { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
        }
        
    }
}