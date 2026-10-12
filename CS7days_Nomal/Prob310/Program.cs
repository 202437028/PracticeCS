using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob310
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            switch (a)
            {
                case "C#":
                    Console.WriteLine("C#言語です");
                    break;
                case "Java":
                    Console.WriteLine("Java言語です");
                    break;
                default:
                    Console.WriteLine("その他の言語です"); 
                    break;
            }
        }
    }
}