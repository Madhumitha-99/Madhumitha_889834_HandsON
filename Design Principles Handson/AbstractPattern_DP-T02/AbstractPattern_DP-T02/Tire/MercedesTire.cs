using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPattern_DP_T03.Tire
{
    public class MercedesTire:ITire
    {
        public override void TireMaker()
        {
            Console.WriteLine("Tire made for Mercedes");
        }
    }
}
