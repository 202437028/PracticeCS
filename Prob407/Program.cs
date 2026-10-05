using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob407
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            while (true)
            {
                int num = rnd.Next(1,100);
                Console.WriteLine(num);
                if(num % 10 == 0)
                {
                    break;
                }
            }
        }
    }
}