using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob502
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = [0.2, -5.1, 3.2, 1.8];
            
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("a[{0}]={1}",i,a[i]);
            }
        }
    }
}