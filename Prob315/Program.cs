using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob315
{
    class Program
    {
        static void Main(string[] args)
        {
            //  キーボードから数値を入力
            Console.Write("年齢を入力:");
            int age = int.Parse(Console.ReadLine());
            if (age < 0)
            {
                Console.WriteLine("正しい年齢を入力してください");
            }
            else if (age <= 12)
            {
                Console.WriteLine("子ども");
            }
            else if (age <= 17)
            {
                Console.WriteLine("中高生");
            }
            else if (age <= 64)
            {
                Console.WriteLine("成人");
            }
            else
            {
                Console.WriteLine("高齢者");
            }
        }
    }
}