using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob601
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc mm = new Calc();   // オブジェクトは1つで十分
            double a = 4.1, b = 2.3;
            double add = mm.Add(a, b);  // 戻り値を変数に代入
            double sub = mm.Sub(a, b);
            double mul = mm.Mul(a, b);
            double div = mm.Div(a, b);
            Console.WriteLine("{0} + {1} = {2:F1}", a, b, add);
            Console.WriteLine("{0} - {1} = {2:F1}", a, b, sub);
            Console.WriteLine("{0} * {1} = {2:F1}", a, b, mul);
            Console.WriteLine("{0} / {1} = {2}", a, b, div);
        }
    }
}