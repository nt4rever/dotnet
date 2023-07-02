using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFundamental
{
    internal class Operator
    {
        public struct Point
        {
            public int x;
            public int y;
            public Point()
            {
                x = 0;
                y = 0;
            }
        }

        public void Example()
        {
            int x = 16, y = 9;
            int add = x + y;
            int mul = x * y;
            float div = (float)x / y;
            int mod = x % y;
            Console.WriteLine($"{add} {mul} {div} {mod}");
            _ = new Point()
            {
                y = mod
            };
            Console.WriteLine(Colors.GREEN);

        }
        enum Colors { RED = 2, BLUE = 5, GREEN }
    }
}

