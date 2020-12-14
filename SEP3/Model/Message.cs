﻿using System;
using System.Text.Json.Serialization;

namespace SEP3.Model
{
    public class Message
    {
        [JsonPropertyName("senderId")]
        public int senderID { get; set; }
        [JsonPropertyName("receiverId")]
        public int recieverID { get; set; }
        public string text { get; set; }
        public DateTime timestamp { get; set; }
        [JsonPropertyName("messageType")]
        public string type { get; set; }
    }
}