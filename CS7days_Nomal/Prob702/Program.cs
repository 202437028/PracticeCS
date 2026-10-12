using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob702
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoStrings s1 = new TwoStrings();
            string sum = s1.GetConnectedString();
            
            s1.String1 = "Hello";
            s1.String2 = "World";
            
            Console.WriteLine("一つ目の文字列は{0}",s1.String1);
            Console.WriteLine("二つ目の文字列は{0}",s1.String2);
            Console.WriteLine("二つの文字列を合成したものは{0}",sum);
        }
    }
}