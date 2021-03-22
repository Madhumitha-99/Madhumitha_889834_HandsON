using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCaseStudy_ObserverPattern
{
    public interface INotificationService
    {
        void AddSubscriber(INotificationObserver notificationObserver);
        void NotifySubscriber();
        void RemoveSubscriber(INotificationObserver notificationObserver);
    }
}
