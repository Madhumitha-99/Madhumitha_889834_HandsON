using System;

namespace SingletonPattern_DP_T02
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConn object1 = DBConn.getInstance();
            DBConn object2 = DBConn.getInstance();
            if (object1 == object2)
            {
                Console.WriteLine("Both the objects are same");
            }

            Console.ReadLine();
        }
    }
}
