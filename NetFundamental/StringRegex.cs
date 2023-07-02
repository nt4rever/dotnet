using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NetFundamental
{
    internal class StringRegex
    {
        public void TestRegex()
        {
            string text = @"Đây là địa chỉ
        email userabcguest@xuanthulab.net.vn và
        xyz@gmail.com cần trích xuất";
            string pattern = @"(([^\s.]+)@((.[^\s]+)(\..[^\s]+)))";
            Regex re = new(pattern);
            MatchCollection matchCollection = re.Matches(text);
            foreach (Match match in matchCollection.Cast<Match>())
            {
                var value = match.Groups[1].Value;
                Console.WriteLine("{0}", value);
            }
        }
    }
}
