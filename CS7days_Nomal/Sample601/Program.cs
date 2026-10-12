using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample601
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1, p2;
            p1 = new Person();  //  1つ目の Person クラスのインスタンスを生成
            p2 = new Person();  //  2つ目の Person クラスのインスタンスを生成
            p1.name = "山田太郎";  //  フィールド name に値を代入
            p1.age  = 19;          //  フィールド age に値を代入
            p2.SetNameAndAge("佐藤花子", 23);  //  SetNameAndAge() メソッドで name と age を設定
            //  ShowNameAndAge() メソッドで、それぞれのインスタンスの name と age を表示
            p1.ShowNameAndAge();
            p2.ShowNameAndAge();
        }
    }
}