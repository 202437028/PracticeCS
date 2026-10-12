using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob409
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int max_num = int.MinValue;
            int min_num = int.MaxValue;

            for (int i = 1; i <= 5; i++)
            {
                int num = rnd.Next(1,101);
                Console.WriteLine(num);
                if(num > max_num)
                {
                    max_num = num;
                }
                if(num < min_num)
                {
                    min_num = num;
                }
            }
            Console.WriteLine("最大値={0}",max_num);
            Console.WriteLine("最小値={0}",min_num);
        }
    }
}