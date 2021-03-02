using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameters
{
    class Program
    {
        public void GetCohortDetails(string name, int count, string mode, string track, string module)
        {
            Console.WriteLine("It is {0} with {1} GenCs undergoing training for {2} thru {3}. The current module of training is {4}", name, count, track, mode, module);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.GetCohortDetails("ADM20DF003", 21, "OBL", ".Net", "C#");
            p.GetCohortDetails(".Net", 21, "OBL", "ADM20DF003", "C#");
            p.GetCohortDetails(track: ".Net", mode: "OBL", name: "ADM20DF003", module: "C#", count: 21);
            Console.ReadLine();
        }
    }
}
