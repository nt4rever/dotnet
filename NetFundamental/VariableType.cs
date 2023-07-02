using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFundamental
{
    internal class VariableType
    {
        private int age = 18;
        public static bool isPrivate = false;
        private byte level = 0;
        public byte Level
        {
            get { return level; }
            set { level = (byte)(value / 2); }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0) age = 0;
                else age = value;
            }
        }

        public static int Sum(int a, int b)
        {
            var s = a + b;
            return s;
        }

         public const int MAX_AGE_TOKEN = 36000;
    }
}
