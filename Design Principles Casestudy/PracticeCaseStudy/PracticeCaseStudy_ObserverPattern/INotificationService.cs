using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCaseStudy_ObserverPattern
{
    public interface INotificationService
    {
        void AddSubscriber(INotificationObserver notificationObserver);
        void RemoveSubscriber(INotificationObserver notificationObserver);
        void NotifySubscriber();
    }
}
