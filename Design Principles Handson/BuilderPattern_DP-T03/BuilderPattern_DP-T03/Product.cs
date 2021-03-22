using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern_DP_T03
{
    public class Product
    {
        private List<string> products = new List<string>();
        public void Add(string product)
        {
            products.Add(product);
        }
        public void Show()
        {
            Console.WriteLine("-----------------");
            foreach(string pr in products)
            {
                Console.WriteLine(pr);
            }
        }
    }
}
