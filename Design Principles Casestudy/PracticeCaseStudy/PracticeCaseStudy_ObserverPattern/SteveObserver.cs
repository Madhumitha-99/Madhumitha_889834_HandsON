using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCaseStudy_ObserverPattern
{
    public class SteveObserver : INotificationObserver
    {
        public string Name{get{return "Steve"; } }
        public void OnServerDown()
        {
            Console.WriteLine(Name + " Server down");
        }
    }
}
