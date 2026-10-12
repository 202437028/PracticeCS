using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample512
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            int m, n, i = 0;
            //  二次元配列に値を代入
            for (m = 0; m < 3; m++)
            {
                for (n = 0; n < 3; n++)
                {
                    a[m,n] = ++i;
                }
            }
            //  二次元配列の値を出力
            for (m = 0; m < 3; m++)
            {
                for (n = 0; n < 3; n++)
                {
                    Console.Write(a[m, n]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}