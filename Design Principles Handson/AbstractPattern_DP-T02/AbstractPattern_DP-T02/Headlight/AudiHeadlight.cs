using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPattern_DP_T03.Headlight
{
    public class AudiHeadlight:IHeadlight
    {
        public override void HeadLightMaker()
        {
            Console.WriteLine("Headlight made for Audi");
        }
    }
}
