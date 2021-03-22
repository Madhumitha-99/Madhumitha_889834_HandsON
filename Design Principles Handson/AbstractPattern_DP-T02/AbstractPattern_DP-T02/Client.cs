using AbstractPattern_DP_T03.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPattern_DP_T03
{
    public class Client
    {
        public void Invoke() 
        { 
        FactoryGetter factoryMake = new FactoryGetter();
        IFactory audi = factoryMake.getFactory("Audi");
        audi.MakeTire().TireMaker();
        audi.MakeHeadlight().HeadLightMaker();
        IFactory mercedes = factoryMake.getFactory("Mercedes");
        mercedes.MakeTire().TireMaker();
        mercedes.MakeHeadlight().HeadLightMaker();
        }
    }
}
