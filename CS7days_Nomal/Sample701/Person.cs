using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample701
{
    class Person
    {
        //  名前（フィールド）
        private string name = "";
        //  年齢（フィールド）
        private int age = 0;

        //  情報の設定（メソッド）
        public void SetNameAndAge(string name, int age)
        {
            this.name = name;
            this.age  = age;
        }
        //  情報の表示（メソッド）
        public void ShowNameAndAge()
        {
            Console.WriteLine("名前：{0} 年齢：{1}", name, age);
        }

        //  Name プロパティ
        public string Name
        {
            set { name = value; }
            get { return name;  }
        }
        //  Age プロパティ
        public int Age
        {
            set { age = value; }
            get { return age;  }
        }
    }
}