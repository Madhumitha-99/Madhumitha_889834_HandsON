using System;

namespace MediatorPattern_DP_T05
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatMediator chatMediator = new ChatMediator();
            IUser sender1 = new BasicUser(chatMediator, "Madhu");
            IUser sender2 = new PremiumUser(chatMediator, "Rathi");
            chatMediator.AddUser(sender1);
            chatMediator.AddUser(sender2);
            sender1.SendMessage("Hi There!!");
            sender2.SendMessage("How are you!!");
            Console.ReadLine();
        }
    }
}
