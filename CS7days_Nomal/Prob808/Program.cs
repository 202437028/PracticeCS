namespace Prob808;

class Program
{
    static void Main(string[] args)
    {
        for(int i = 2; i <= 10000; i++)
        {
            // 変数の初期化
            int numInt = 0;
            string numStr = "";

            for(int j = 1; j < i; j++)
            {   
                if(i % j == 0)
                {
                    numInt += j;
                    if (numStr == "")   {numStr += j;}
                    else                {numStr += "+" + j;}
                }
            }
            // 完全数の場合は出力
            if (numInt == i)
            {
                Console.WriteLine("{0} ({1}={2})",i,numStr,numInt);
            }
        }
        Console.WriteLine();
    }
}