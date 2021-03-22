using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCaseStudy_AbstractPattern
{
    public class Client
    {
        Factory _factory;
        public Client(Factory factory)
        {
            this._factory = factory;
        }
        public void MakeElectronics(Channel channel)
        {
            _factory.ProcessOrder(channel, Product.Electronics);
        }
        public void MakeFurniture(Channel channel)
        {
            _factory.ProcessOrder(channel, Product.Furniture);
        }
        public void MakeToys(Channel channel)
        {
            _factory.ProcessOrder(channel, Product.Toys);
        }
    }
}
