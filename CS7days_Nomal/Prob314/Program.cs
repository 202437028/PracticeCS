using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob314
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("正の数");
            }
            else if(a < 0)
            {
                Console.WriteLine("負の数");
            }
            else if(a == 0)
            {
                Console.WriteLine("0");
            }
        }
    }
}