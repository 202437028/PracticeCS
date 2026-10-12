using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob701
{
    class Program
    {
        static void Main(string[] args)
        {
            Data d1;
            d1 = new Data();  //  1つ目の Data クラスのインスタンスを生成
            d1.Number = 100;  //  Number プロパティで num に値を代入
            d1.Comment  = "Programming C#";          //  Comment プロパティで com に値を代入

            //  プロパティからナンバーとコメントを表示
            Console.WriteLine("number = {0}\ncomment = {1}", d1.Number, d1.Comment);
        }
    }
}