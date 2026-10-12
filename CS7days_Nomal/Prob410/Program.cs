namespace Prob410;

class Program
{
    static void Main(string[] args)
    {
        for(int i = 0; i <= 9; i++)
        {
            for(int j = 1; j <= 10; j++)
            {
                Console.Write("{0} ",j+i*10);
            }
            Console.WriteLine();
        }
    }
}
