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
            int a,b,c;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            c = int.Parse(Console.ReadLine());

            if (a >= b && a >= c)
            {
                Console.WriteLine("最大値: a={0}",a);
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine("最大値: b={0}",b);
            }
            else if (c >= a && c >= b)
            {
                Console.WriteLine("最大値: c={0}",c);
            }
        }
    }
}