using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob509
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] n = new int[10];

            for (int i = 0; i < n.Length; i++)
            {
                n[i] = rnd.Next(1, 101);

                if (n[i] >= 50)     {Console.Write(n[i]+" ");}
            }
            Console.WriteLine();
        }
    }
}