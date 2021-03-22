using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCaseStudy_ObserverPattern
{
    public class AdminObserver:INotificationObserver
    {
        public string EventName { get { return "Cultural Event"; } }
        public void EmailNotification()
        {
            Console.WriteLine("Email Notification : More than 100 Tickets have been booked for the " + EventName);
        }
        public void SMSNotification()
        {
            Console.WriteLine("SMS Notification : More than 100 Tickets have been booked for the " + EventName);
        }
        public void WhatsAppNotification()
        {
            Console.WriteLine("Whatsapp Notification : More than 100 Tickets have been booked for the" + EventName);
        }
    }
}
