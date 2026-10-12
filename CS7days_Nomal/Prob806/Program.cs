namespace Prob806;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("一つ目の分数の分子を入力してください：");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("一つ目の分数の分母を入力してください：");
        int den1 = int.Parse(Console.ReadLine());
        Console.Write("二つ目の分数の分子を入力してください：");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("二つ目の分数の分母を入力してください：");
        int den2 = int.Parse(Console.ReadLine());
        
        int sumDen = den1*den2;
        int sumNum = num1*den2 + num2*den1;

        int a = sumNum;
        int b = sumDen;

        while (b != 0)
        {
            int remainder = a % b;  // 余りを求める
            a = b;                  // 割る数を、次の「割られる数」にする
            b = remainder;          // 余りを、次の「割る数」にする
        }

        sumDen = sumDen/a;
        sumNum = sumNum/a;

        Console.WriteLine("{0}/{1} + {2}/{3} = {4}/{5}",num1,den1,num2,den2,sumNum,sumDen);
    }
}
