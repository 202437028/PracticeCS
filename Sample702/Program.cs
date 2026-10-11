using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample702
{
    class Program
    {
        static void Main(string[] args)
        {
            Access a = new Access();
            //a.Data1 = 1;  // Data1 は読み込み専用なのでコメントを外すとエラー
            a.Data2 = 2;
            a.ShowDatas();
            Console.WriteLine("a.Data1 = {0}", a.Data1);
            //Console.WriteLine("a.Data2 = {0}", a.Data2);  // Data2 は書き込み専用なのでエラー
        }
    }
}