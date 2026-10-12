using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample513
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] a = new int[3, 3];
            int m, n;
            int max = int.MinValue, min = int.MaxValue;
            //  二次元配列に値を代入
            for (m = 0; m < 3; m++)
            {
                for (n = 0; n < 3; n++)
                {
                    a[m,n] = rnd.Next(1, 10);;
                    if (a[m, n] > max) {max = a[m, n];}
                    if (a[m, n] < min) {min = a[m, n];}
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
            Console.WriteLine("最大値: {0}",max);
            Console.WriteLine("最小値: {0}",min);
        }
    }
}