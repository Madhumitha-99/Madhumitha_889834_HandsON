using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCaseStudy_ObserverPattern
{
    class JohnObserver:INotificationObserver
    {
        public string Name { get { return "John"; } }
        public void OnServerDown()
        {
            Console.WriteLine(Name + " Server down");
        }
    }
}
