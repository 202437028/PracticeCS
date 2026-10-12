using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob309
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            switch (a)
            {
                case "yes":
                    Console.WriteLine("はい");
                    break;
                default:
                    Console.WriteLine("いいえ"); 
                    break;
            }
        }
    }
}