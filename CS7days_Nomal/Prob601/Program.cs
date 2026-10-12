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
            MinMax mm = new MinMax();   // オブジェクトは1つで十分
            int a = 4, b = 2, c = 7;
            int max = mm.Max(a, b, c);  // 戻り値を変数に代入
            int min = mm.Min(a, b, c);
            Console.WriteLine("{0}と{1}と{2}のうち最大のものは{3}です。", a, b, c, max);
            Console.WriteLine("{0}と{1}と{2}のうち最小のものは{3}です。", a, b, c, min);
        }
    }
}