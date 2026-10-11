using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample702
{
    class Access
    {
        //  読み込み専用のデータ
        private int data1 = 5;
        //  書き込み専用のデータ
        private int data2 = 0;
        //  値の表示
        public void ShowDatas()
        {
            Console.WriteLine("data1={0} data2={1}", data1, data2);
        }
        //  data1 のプロパティ（読み込み専用）
        public int Data1
        {
            get { return data1; }
        }
        //  data2 のプロパティ（書き込み専用）
        public int Data2
        {
            set { data2 = value; }
        }
    }
}