﻿using System.Collections.Generic;
using System.Threading.Tasks;
using SEP3.Model;

namespace SEP3.Data
{
    public interface ICloudMessageService
    {
        public Task<List<Message>> GetMessagesToMe(int idNr);
        public Task<List<Message>> GetMessagesFromToAndToFrom(int me, int someone);
        public Task SendMessage(Message message);
        public Task<List<Message>> GetNotifications();
    }
}