using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCaseStudy_ObserverPattern
{
    public interface INotificationObserver
    {
        string EventName { get; }
        void EmailNotification();
        void SMSNotification();
        void WhatsAppNotification();
    }
}
