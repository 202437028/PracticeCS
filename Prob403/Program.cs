using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob403
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int i = 0;
            do
            {
                Console.Write("■");
                i++;
            }while(num > i);
            Console.WriteLine();
        }
    }
}