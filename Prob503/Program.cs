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
            int[] n = new int[10];
            int even_num = 0, odd_num = 0;
            
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = rnd.Next(1,101);
                Console.WriteLine(n[i]);
                if (n[i] % 2 == 0)
                {
                    even_num++;
                }
                else
                {
                    odd_num++;
                }
            }
            Console.WriteLine("偶数:{0}個",even_num);
            Console.WriteLine("奇数:{0}個",odd_num);
        }
    }
}