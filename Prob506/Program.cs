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
            int max = int.MinValue, min = int.MaxValue;
            double sum = 0, ave;

            for (int i = 0; i < n.Length; i++)
            {
                n[i] = rnd.Next(1, 101);
                sum += n[i];

                if (n[i] > max)     {max = n[i];}
                if (n[i] < min)     {min = n[i];}
            }
            ave = sum/n.Length;

            Console.WriteLine("最大値: {0}",max);
            Console.WriteLine("最小値: {0}",min);
            Console.WriteLine("平均値: {0:F1}",ave);
        }
    }
}