using System;

namespace FinalCaseStudy_ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AdminObserver adminObserver = new AdminObserver();
            NotificationService service = new NotificationService();
            service.AddSubscriber(adminObserver);
            
                Console.WriteLine("Enter number of tickets for the Event");
                int count = Convert.ToInt32(Console.ReadLine());
                if(count > 100)
                {
                    service.NotifySubscriber();
                }
                else
                {
                    Console.WriteLine("Tickets Booked Successfully!!!");
                }
            
            service.RemoveSubscriber(adminObserver);
            Console.ReadLine();
        }
    }
}
