using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob511
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] n = new int[5];
            string isLessthan60 = "",is60ormoreLessthan80 = "",is80ormore = "";

            for (int i = 0; i < n.Length; i++)
            {
                n[i] = rnd.Next(1, 101);

                if (n[i] < 60)          {isLessthan60 += n[i]+" ";}
                else if (n[i] < 80)     {is60ormoreLessthan80 += n[i]+" ";}
                else if (n[i] >= 80)    {is80ormore += n[i]+" ";}
            }

            Console.WriteLine("60未満: {0}",isLessthan60);
            Console.WriteLine("60以上80未満: {0}",is60ormoreLessthan80);
            Console.WriteLine("80以上: {0}",is80ormore);
        }
    }
}