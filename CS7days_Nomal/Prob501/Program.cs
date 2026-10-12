using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob501
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] n = new int[7];
            
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = rnd.Next(1,11);
                Console.WriteLine(n[i]);
            }
        }
    }
}