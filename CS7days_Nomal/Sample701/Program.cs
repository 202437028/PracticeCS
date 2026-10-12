using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample701
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1, p2;
            p1 = new Person();  //  1つ目の Person クラスのインスタンスを生成
            p2 = new Person();  //  2つ目の Person クラスのインスタンスを生成
            p1.Name = "山田太郎";  //  Name プロパティで name に値を代入
            p1.Age  = 19;          //  Age プロパティで age に値を代入
            p2.SetNameAndAge("佐藤花子", 23);  //  SetNameAndAge() メソッドで name と age を設定
            p1.ShowNameAndAge();  //  メソッドから名前と年齢を表示
            //  プロパティから名前と年齢を表示
            Console.WriteLine("名前：{0} 年齢：{1}", p2.Name, p2.Age);
        }
    }
}