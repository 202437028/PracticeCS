namespace Prob809;

class Program
{
    static void Main(string[] args)
    {
        int [] F = new int[20];
        F[0] = 1;
        F[1] = 1;

        for(int i = 0; i < F.Length; i++)
        {
            if (1 < i)
            {
                F[i] = F[i-1] + F[i-2];
            }
            Console.Write(F[i] + " ");
        }
    }
}
