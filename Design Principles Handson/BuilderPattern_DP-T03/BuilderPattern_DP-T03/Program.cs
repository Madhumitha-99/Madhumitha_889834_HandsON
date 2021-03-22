using System;

namespace BuilderPattern_DP_T03
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            Builder builder = new AdultPackageConcrete();
            Builder builder1 = new ChildPackageConcrete();

            director.Construct(builder);
            Product product = builder.GetResult();
            Console.WriteLine("Adult Package");
            product.Show();

            director.Construct(builder1);
            Product product1 = builder1.GetResult();
            Console.WriteLine("\nChild Package");
            product1.Show();

            Console.ReadLine();
        }
    }
}
