using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample703
{
    class Person2
    {
        //  情報の設定（メソッド）
        public void SetNameAndAge(string name, int age)
        {
            Name = name;
            Age  = age;
        }
        //  情報の表示（メソッド）
        public void ShowNameAndAge()
        {
            Console.WriteLine("名前：{0} 年齢：{1}", Name, Age);
        }
        //  Name プロパティ（クラス外からは読み込み専用）
        public string Name
        {
            private set; get;
        }
        //  Age プロパティ（読み書き両方対応）
        public int Age
        {
            set; get;
        }
    }
}