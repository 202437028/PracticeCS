namespace Prob803;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("正の整数を入力してください：");
        int num = int.Parse(Console.ReadLine());
        long factorial = 1;
        for (int i = num; i > 0; i--)
        {
            factorial = factorial*i;
        }
        Console.WriteLine("{0}! = {1}",num,factorial);
    }
}
