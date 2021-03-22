using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern_DP_T05
{
    public interface IChatMediator
    {
        void AddUser(IUser user);
        void SendMessage(string message,IUser sender);
    }
}
