using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob311
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a >= 0 && a <= 100)
            {
                Console.WriteLine("有効な範囲です");
            }
            else
            {
                Console.WriteLine("範囲外です");
            }
        }
    }
}