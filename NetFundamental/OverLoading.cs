using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFundamental
{
    internal class OverLoading
    {
        public static int Sum(List<int> list)
        {
            int sum = 0;
            list.ForEach(x => sum += x);
            return sum;
        }

        public static double Sum(List<double> list)
        {
            double sum = 0;
            list.ForEach(x => sum += x);
            return sum;
        }
    }
}
