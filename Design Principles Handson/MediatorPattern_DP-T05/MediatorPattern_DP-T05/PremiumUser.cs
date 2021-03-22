using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern_DP_T05
{
    public class PremiumUser : IUser
    {
        string name;
        IChatMediator mediator;
        public PremiumUser(IChatMediator chatMediator,string userName)
        {
            this.name = userName;
            this.mediator = chatMediator;
        }
        public void SendMessage(string message)
        {
            mediator.SendMessage(message, this);
        }
        public void ReceiveMessage(string message)
        {
            Console.WriteLine(name + " received " + message);
        }
    }
}
