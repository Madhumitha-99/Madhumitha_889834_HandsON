using AbstractPattern_DP_T03.Headlight;
using AbstractPattern_DP_T03.Tire;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPattern_DP_T03.Factory
{
    public abstract class IFactory
    {

        public abstract ITire MakeTire();
        public abstract IHeadlight MakeHeadlight();
    }
}
