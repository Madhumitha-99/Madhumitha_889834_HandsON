using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern_DP_T03
{
    class ChildPackageConcrete : Builder
    {
        private Product pr = new Product();
        public void Sweets()
        {
            pr.Add("2 Sweets");
        }
        public void Savouries()
        {
            pr.Add("1 Savouries");
        }
        public Product GetResult()
        {
            return pr;
        }
    }
}
