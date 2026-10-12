using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob507
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] n = new int[5];
            double sum = 0, ave;
            string up="",down="";

            for (int i = 0; i < n.Length; i++)
            {
                n[i] = rnd.Next(1, 101);
                sum += n[i];
            }
            ave = sum/n.Length;

            for (int i = 0; i < n.Length; i++)
            {
                if (ave <= n[i])    {up += n[i] + " ";}
                else                {down += n[i] + " ";}           
            }
            Console.WriteLine("平均値: {0}",ave);
            Console.WriteLine("平均以上の要素: {0}",up);
            Console.WriteLine("平均以下の要素: {0}",down);
        }
    }
}