using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob313
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数字を入力(1=月 ... 7=日) :");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("月曜日");
                    break;
                case 2:
                    Console.WriteLine("火曜日");
                    break;
                case 3:
                    Console.WriteLine("水曜日");
                    break;
                case 4:
                    Console.WriteLine("木曜日");
                    break;
                case 5:
                    Console.WriteLine("金曜日");
                    break;
                case 6:
                    Console.WriteLine("土曜日");
                    break;
                case 7:
                    Console.WriteLine("日曜日");
                    break;
                default: 
                    break;
            }
        }
    }
}