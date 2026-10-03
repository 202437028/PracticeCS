using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob201
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10,b = 3;
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);           //  足し算
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);           //  引き算
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);           //  掛け算
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);           //  剰余
        }
    }
}