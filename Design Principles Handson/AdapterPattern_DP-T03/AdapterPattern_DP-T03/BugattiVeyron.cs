using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern_DP_T03
{
    class BugattiVeyron:Movable
    {
        public double GetSpeed()
        {
            return 268;
        }

        public double GetPrice()
        {
            return 150;
        }
    }
}
