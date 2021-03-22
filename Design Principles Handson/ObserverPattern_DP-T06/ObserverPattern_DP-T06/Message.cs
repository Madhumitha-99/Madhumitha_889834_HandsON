using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern_DP_T06
{
    public class Message
    {
        string messageContent;
        public Message(string m)
        {
            this.messageContent = m;
        }
        public string getMessageContent()
        {
            return messageContent;
        }
    }
}
