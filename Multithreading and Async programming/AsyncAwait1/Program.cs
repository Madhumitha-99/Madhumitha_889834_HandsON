using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncAwait1
{
    class Program
    {
        public async static Task FirstMethod()
        {
            string method1 = await SecondMethod();
            Console.WriteLine(method1);
        }
        public async static Task<string> SecondMethod()
        {
            Thread.Sleep(1000);
            return "Method 2 displaying Method 1";
        }
        static void Main(string[] args)
        {
            FirstMethod();
            Console.ReadLine();
        }
    }
}
