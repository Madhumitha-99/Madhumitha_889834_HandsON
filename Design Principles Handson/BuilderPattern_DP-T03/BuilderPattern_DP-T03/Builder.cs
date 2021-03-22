using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern_DP_T03
{
    public interface Builder
    {
        void Sweets();
        void Savouries();
        Product GetResult();
    }
}
