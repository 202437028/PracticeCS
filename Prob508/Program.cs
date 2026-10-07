using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob508
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[5];
            int posi = 0,nega = 0,zero = 0;

            for (int i = 0; i < n.Length; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
                if(n[i] > 0)     {posi++;}
                if(n[i] < 0)     {nega++;}
                if(n[i] == 0)    {zero++;}
            }

            Console.WriteLine("正の数: {0}個",posi);
            Console.WriteLine("負の数: {0}個",nega);
            Console.WriteLine("ゼロ: {0}個",zero);
        }
    }
}