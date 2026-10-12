using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob504
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] n = new int[10];
            string down = "", up = "";

            for (int i = 0; i < n.Length; i++)
            {
                n[i] = rnd.Next(1, 101);

                if (n[i] < 50) 
                {
                    down += n[i] + " ";
                }
                else
                {
                    up   += n[i] + " ";
                }           
            }

            Console.WriteLine("50未満の数: {0}",down);
            Console.WriteLine("50以上の数: {0}",up);
        }
    }
}