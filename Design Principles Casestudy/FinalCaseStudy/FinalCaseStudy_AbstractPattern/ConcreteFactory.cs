using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCaseStudy_AbstractPattern
{
    public class ConcreteFactory:Factory
    {
        private Order order;
        public void ProcessOrder(Channel channel,Product product)
        {
            if (product == Product.Electronics)
            {
                order = new ElectronicOrder(channel);
            }
            else if (product == Product.Furniture)
            {
                order = new FurnitureOrder(channel);
            }
            else
            {
                order = new ToysOrder(channel);
            }
        }
    }
}
