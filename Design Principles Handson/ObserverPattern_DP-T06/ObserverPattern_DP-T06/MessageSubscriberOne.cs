using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern_DP_T06
{
    public class MessageSubscriberOne : Observer
    {
        public void Update(Message m)
        {
            Console.WriteLine("Message SubscriberOne ::" + m.getMessageContent());
        }
    }
    public class MessageSubscriberTwo : Observer
    {
        public void Update(Message m)
        {
            Console.WriteLine("Message SubscriberTwo ::" + m.getMessageContent());
        }
    }
    public class MessageSubscribeThree : Observer
    {
        public void Update(Message m)
        {
            Console.WriteLine("Message SubscriberThree ::" + m.getMessageContent());
        }
    }
}
