using System;

namespace AdapterPattern_DP_T03
{
    class Program
    {
        static void Main(string[] args)
        {
            Movable bugatti = new BugattiVeyron();
            MovableAdapter car = new MovableAdapterImpl(bugatti);
            Console.WriteLine("Speed in MPH: " + bugatti.GetSpeed());
            Console.WriteLine("Speed in KMPH: " + car.GetSpeed());
            Console.WriteLine("Price in USD: " + bugatti.GetPrice());
            Console.WriteLine("Price in Euro: " + car.GetPrice());
            Console.ReadLine();
        }
    }
}
