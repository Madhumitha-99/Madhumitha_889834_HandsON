using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCaseStudy_ObserverPattern
{
    public class NotificationService:INotificationService
    {
        List<INotificationObserver> notificationObservers = new List<INotificationObserver>();

        public void AddSubscriber(INotificationObserver observer)
        {
            notificationObservers.Add(observer);
            Console.WriteLine(observer.Name + " is added to Subscription List \n\n List of Subcribers");
            foreach(var observe in notificationObservers)
            {
                Console.WriteLine(observe.Name);
            }
        }
        public void NotifySubscriber()
        {
            foreach(var o in notificationObservers)
            {
                o.OnServerDown();
            }
        }
        public void RemoveSubscriber(INotificationObserver observer)
        {
            notificationObservers.Remove(observer);
            Console.WriteLine(observer.Name + " is removed from the Subscription List");
            Console.WriteLine("List of Subscribers");
            foreach(var o in notificationObservers)
            {
                Console.WriteLine(o.Name);
            }
        }
    }
}
