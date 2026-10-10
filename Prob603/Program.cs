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
            Circle c = new Circle(4.0);
            double circumference = c.Circumference();
            double area = c.Area();
            Console.WriteLine("半径{0:F1}の円の円周の長さは{1}", 4.0, circumference);
            Console.WriteLine("半径{0:F1}の円の面積は{1}", 4.0, area);

        }
    }
}