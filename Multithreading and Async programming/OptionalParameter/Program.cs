using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    class Program
    {
        public static void OrderDetails(string sellerName,string productName,int orderQuantity=1,bool isReturnable = true)
        {
            Console.WriteLine("Here is the order details- {0} {1} from {2} is ordered.It's returnable status is {3}", orderQuantity, productName, sellerName, isReturnable);
        }
        static void Main(string[] args)
        {
            OrderDetails("Amazon", "Mobile phone");
            OrderDetails("Flipkart", "Laptop", 2, false);
            Console.ReadLine();
        }
    }
}
