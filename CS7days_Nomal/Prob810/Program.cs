using System.Runtime.CompilerServices;

namespace Prob810;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] list = new int[10];
        for(int i = 0; i < list.Length; i++)
        {
            list[i] = rnd.Next(1, 101);
            Console.Write(list[i]+" ");
        }
        Console.WriteLine();

        // 選択ソート
        for(int i = 0; i < list.Length; i++)
        {
            int min = int.MaxValue;
            int minIndex = i;
            for(int j = i; j < list.Length; j++)
            {
                if(list[j] < min)
                {
                    min = list[j]; 
                    minIndex = j;
                }
            }
            list[minIndex] = list[i];
            list[i] = min;
            Console.Write(list[i]+" ");
        }
    }
}

