using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob703
{
    class Calculation
    {
        //  フィールド
        private int number1;
        private int number2;

        //  プロパティ
        public int Number1
        {
            set { number1 = value; }
            get { return number1;  }
        }
        public int Number2
        {
            set { number2 = value; }
            get { return number2;  }
        }

        //  メソッド
        public int Add()
        {
            return number1 + number2;
        }
        public int Sub()
        {
            return number1 - number2;
        }
    }
}