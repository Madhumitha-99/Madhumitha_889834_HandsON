using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern_DP_T05
{
    public interface IUser
    {
        //string Name { get; set; }
        void ReceiveMessage(string message);
        void SendMessage(string message);
    }
}
