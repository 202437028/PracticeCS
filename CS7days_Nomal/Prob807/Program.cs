namespace Prob807;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int num = rnd.Next(1, 1001);
        Console.WriteLine("乱数: "+ num);
        for(int i = 1; i <= num; i++)
        {
            if(num % i == 0)
            {
                Console.Write(i+" ");
            }
        }
        Console.WriteLine();
    }
}