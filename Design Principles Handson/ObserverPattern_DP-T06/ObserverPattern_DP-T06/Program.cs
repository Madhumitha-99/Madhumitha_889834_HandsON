using System;

namespace ObserverPattern_DP_T06
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageSubscriberOne s1 = new MessageSubscriberOne();
            MessageSubscriberTwo s2 = new MessageSubscriberTwo();
            MessageSubscribeThree s3 = new MessageSubscribeThree();
            MessagePublisher p = new MessagePublisher();
            p.Attach(s1);
            p.Attach(s2);
            p.NotifyUpdate(new Message("First Message"));
            p.Detach(s1);
            p.Attach(s3);
            p.NotifyUpdate(new Message("Second Message"));
            //p.Attach(s1);
            //p.Attach(s2);
            //p.Attach(s3);
            //p.ChangeState(2);
            Console.ReadLine();
        }
    }
}
