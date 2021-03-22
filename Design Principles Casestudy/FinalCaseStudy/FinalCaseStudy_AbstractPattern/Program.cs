using System;

namespace FinalCaseStudy_AbstractPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new ConcreteFactory();
            Client client = new Client(factory);
            client.MakeElectronics(Channel.ECommerceWebsite);
            
            client.MakeToys(Channel.TeleCallerAgentsApplication);
            
            client.MakeFurniture(Channel.TeleCallerAgentsApplication);
            Console.ReadLine();
        }
    }
    public enum Product
    {
        Electronics, Toys, Furniture
    }
    public enum Channel
    {
        ECommerceWebsite, TeleCallerAgentsApplication
    }
    public abstract class Order
    {
        public Channel channel { get; set; }
        public Product product { get; set; }
        public Order(Product productType, Channel channel)
        {
            this.product = productType;
            this.channel = channel;
        }
        public abstract void processOrder();
    }
    public class ElectronicOrder : Order
    {
        public ElectronicOrder(Channel channel) : base(Product.Electronics, channel)
        {
            processOrder();
        }
        public override void processOrder()
        {
            Console.WriteLine(product.ToString() + " order is placed in " + channel.ToString());
        }
    }
    public class ToysOrder : Order
    {
        public ToysOrder(Channel channel) : base(Product.Toys, channel)
        {
            processOrder();
        }
        public override void processOrder()
        {
            Console.WriteLine(product.ToString() + " order is placed in " + channel.ToString());
        }
    }
    public class FurnitureOrder : Order
    {
        public FurnitureOrder(Channel channel) : base(Product.Furniture, channel)
        {
            processOrder();
        }
        public override void processOrder()
        {
            Console.WriteLine(product.ToString() + " order is placed in " + channel.ToString());
        }
    }
}
