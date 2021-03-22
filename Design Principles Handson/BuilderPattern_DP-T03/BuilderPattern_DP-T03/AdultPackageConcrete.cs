using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern_DP_T03
{
    public class AdultPackageConcrete : Builder
    {
        private Product pr = new Product();
        public void Sweets()
        {
            pr.Add("2 Sweets");
        }
        public void Savouries()
        {
            pr.Add("2 Savouries");
        }
        public Product GetResult()
        {
            return pr;
        }
    }
}
