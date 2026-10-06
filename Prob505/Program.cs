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
            string isMultipleOf3 = "", isNotMultipleOf3 = "";

            for (int i = 0; i < n.Length; i++)
            {
                n[i] = rnd.Next(1, 101);

                if (n[i] % 3 == 0) 
                {
                    isMultipleOf3 += n[i] + " ";
                }
                else
                {
                    isNotMultipleOf3   += n[i] + " ";
                }           
            }

            Console.WriteLine("3の倍数: {0}",isMultipleOf3);
            Console.WriteLine("3の倍数以外: {0}",isNotMultipleOf3);
        }
    }
}