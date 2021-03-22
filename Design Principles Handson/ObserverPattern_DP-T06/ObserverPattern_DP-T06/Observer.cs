using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern_DP_T06
{
    public interface Observer
    {
        public void Update(Message m);
    }
}
