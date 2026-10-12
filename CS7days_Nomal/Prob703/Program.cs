using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob703
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation d1 = new Calculation();
            
            d1.Number1 = 8;
            d1.Number2 = 9;

            int plus = d1.Add();
            int minus = d1.Sub();
            Console.WriteLine("{0} + {1} = {2}",d1.Number1,d1.Number2,plus);
            Console.WriteLine("{0} - {1} = {2}",d1.Number1,d1.Number2,minus);
        }
    }
}