using AbstractPattern_DP_T03.Headlight;
using AbstractPattern_DP_T03.Tire;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPattern_DP_T03.Factory
{
    public class MercedesFactory:IFactory
    {
        public override ITire MakeTire()
        {
            return new MercedesTire();
        }
        public override IHeadlight MakeHeadlight()
        {
            return new MercedesHeadlight();
        }
    }
}
