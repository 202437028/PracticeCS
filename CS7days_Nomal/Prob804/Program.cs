namespace Prob804;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int ransuu = rnd.Next(1, 1001);
        int nagasa = ransuu.ToString().Length;

        Console.WriteLine("{0}は{1}桁",ransuu,nagasa);
    }
}
