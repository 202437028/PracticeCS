namespace Prob805;

class Program
{
    static void Main(string[] args)
    {
        for(int i = 1;i <= 100; i++)
        {
            if (i.ToString().Contains("3") || i % 3 == 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}
