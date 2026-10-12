using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob702
{
    class TwoStrings
    {
        //  フィールド
        private string string1 = "";
        private string string2 = "";

        //  プロパティ
        public string String1
        {
            set { string1 = value; }
            get { return string1;  }
        }
        public string String2
        {
            set { string2 = value; }
            get { return string2;  }
        }

        //  メソッド
        public string GetConnectedString()
        {
            return string1 + string2;
        }
    }
}