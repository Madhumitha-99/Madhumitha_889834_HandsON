using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern_DP_T05
{
    public class BasicUser:IUser
    {
        IChatMediator chatMediator;
        string name;

        public BasicUser(IChatMediator mediator,string userName)
        {
            this.chatMediator = mediator;
            this.name = userName;
        }
        public void SendMessage(string message)
        {
            chatMediator.SendMessage(message, this);
        }
        public void ReceiveMessage(string message)
        {
            Console.WriteLine(name + " received " + message);
        }
    }
}
