using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern_DP_T03
{
    class Director
    {
        public void Construct(Builder builder)
        {
            builder.Sweets();
            builder.Savouries();
        } 
    }
}
