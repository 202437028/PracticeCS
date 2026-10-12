using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob402
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int i = 0;
            while (num > i)
            {
                Console.Write("■");
                i++;
            }
            Console.WriteLine();
        }
    }
}