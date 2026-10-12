namespace Prob412;

class Program
{
    static void Main(string[] args)
    {
        int line = int.Parse(Console.ReadLine());
        for(int i = 1; i <= line; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write("☆");
            }
            Console.WriteLine();
        }
    }
}
