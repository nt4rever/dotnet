using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFundamental
{
    internal class Collection
    {
        public void DemoDictionary()
        {
            // [1,2,3,5,3,5,2]
            // [3,4,1,4] -> [1,3]
            int[] arr1 = new int[] { 1, 2, 3, 5, 3, 5, 2 };
            int[] arr2 = new int[] { 3, 4, 1, 4 };
            var set = new HashSet<int>(arr1);
            var result = new List<int>();
            Array.ForEach(arr2, (x) =>
            {
                if (set.Contains(x)) result.Add(x); 
            });
            //result.ForEach((x) =>
            //{
            //    Console.WriteLine(x);
            //});
        }
    }
}
