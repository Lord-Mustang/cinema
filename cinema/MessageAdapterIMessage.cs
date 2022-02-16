﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cinema.lib;

namespace cinema
{
    public class MessageAdapterIMessage : MessageAdapter
    {
        public IMessage instance;

        public MessageAdapterIMessage()
        {
            this.instance = new IMessage();
        }

        public void SendMessage(string message)
        {
            // Dummy receiver
            instance.SendMessage("IMessage: " + message, 1);
        }
    }
}