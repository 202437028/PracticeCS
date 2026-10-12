using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob207
{
    class Program
    {
        static void Main(string[] args)
        {
            int price;
            const double tax = 0.1;

            Console.Write ("価格を入力：");
            price = int.Parse(Console.ReadLine());
            Console.WriteLine("税込価格：" + (int)(price + price * tax));
        }
    }
}