using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCaseStudy_ObserverPattern
{
    public interface INotificationObserver
    {
        string Name { get; }
        void OnServerDown();
    }
}
