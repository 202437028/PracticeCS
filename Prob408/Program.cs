using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob408
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int i = 1; i <= 5; i++)
            {
                int num = rnd.Next(1,100);
                Console.WriteLine(num);
            }
        }
    }
}