using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob701
{
    class Data
    {
        //  ナンバー（フィールド）
        private int num = 0;
        //  コメント（フィールド）
        private string com = "";


        //  Number プロパティ
        public int Number
        {
            set { num = value; }
            get { return num;  }
        }
        //  Comment プロパティ
        public string Comment
        {
            set { com = value; }
            get { return com;  }
        }

        //  情報の設定（メソッド）
        public void SetNumberAndComment(int num, string com)
        {
            this.num = num;
            this.com = com;
        }
    }
}