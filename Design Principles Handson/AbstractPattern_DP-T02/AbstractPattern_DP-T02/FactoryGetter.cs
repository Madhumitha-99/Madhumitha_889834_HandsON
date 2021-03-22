using AbstractPattern_DP_T03.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPattern_DP_T03
{
    public class FactoryGetter
    {
        public IFactory getFactory(String factory)
        {
            if (factory.Equals("Audi"))
            {
                return new AudiFactory();
            }
            else if (factory.Equals("Mercedes"))
            {
                return new MercedesFactory();
            }
            else
                return null;
           
        }
    }
}
