using System;

namespace PracticeCaseStudy_ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            JohnObserver johnObserver = new JohnObserver();
            SteveObserver steveObserver = new SteveObserver();
            NotificationService notification = new NotificationService();
            notification.AddSubscriber(johnObserver);
            notification.NotifySubscriber();
            notification.AddSubscriber(steveObserver);
            notification.NotifySubscriber();
            notification.RemoveSubscriber(steveObserver);
            notification.NotifySubscriber();
            Console.ReadLine();
        }
    }
}
