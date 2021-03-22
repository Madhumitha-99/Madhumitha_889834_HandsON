using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCaseStudy_ObserverPattern
{
    public class NotificationService:INotificationService
    {
        List<INotificationObserver> notificationObservers = new List<INotificationObserver>();
        public void AddSubscriber(INotificationObserver observer)
        {
            notificationObservers.Add(observer);
            Console.WriteLine("Subscriber Added");
        }
        public void NotifySubscriber()
        {
            Console.WriteLine("Notification to Admin");
            foreach(var i in notificationObservers)
            {
                i.EmailNotification();
                i.SMSNotification();
                i.WhatsAppNotification();
            }
        }
        public void RemoveSubscriber(INotificationObserver observer)
        {
            notificationObservers.Remove(observer);
            Console.WriteLine("Subscriber Removed");
        }
    }
}
