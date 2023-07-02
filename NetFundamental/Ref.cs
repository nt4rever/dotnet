using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFundamental
{
    internal class Ref
    {
        public static void Swap(ref int i, ref int j)
        {
            (j, i) = (i, j);
        }

        public static void TimeOut(out int n, int i)
        {
            n = 3600 * i;
        }

        public static void SwapGeneral<T>( ref T a, ref T b)
        {
            (b, a) = (a, b);
        }
    }
}
