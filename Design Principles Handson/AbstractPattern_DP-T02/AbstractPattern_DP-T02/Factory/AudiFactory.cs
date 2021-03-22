using AbstractPattern_DP_T03.Headlight;
using AbstractPattern_DP_T03.Tire;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPattern_DP_T03.Factory
{
    public class AudiFactory:IFactory
    {
        public override ITire MakeTire()
        {
            return new AudiTire();
        }
        public override IHeadlight MakeHeadlight()
        {
            return new AudiHeadlight();
        }
    }
}
