using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob304
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("等しい");
            }
            else
            {
                Console.WriteLine("等しくない");
            }
        }
    }
}