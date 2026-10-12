namespace Prob802;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            for (int j = i; j <= 100; j++)
            {
                for (int k = 1; k <= 100; k++)
                {
                    if (i*i+j*j==k*k)
                    {
                        Console.WriteLine("{0}^2 + {1}^2 = {2}^2({3})",i,j,k,k*k);
                    }
                }
            }
        }
    }
}
