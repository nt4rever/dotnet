using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFundamental
{
    internal class Log
    {
        public delegate void ShowLog(string message);

        public void Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Format("Info: {0}", message));
            Console.ResetColor();
        }

        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Format("Error: {0}", message));
            Console.ResetColor();
        }

        public void TestShowLog()
        {
            ShowLog? showLog = null;
            //showLog = Info;
            //showLog("Neu mai ta roi xa");
            //showLog = Error;
            //showLog("Roi minh se gap nhau");
            showLog += Info;
            showLog += Error;
            showLog("Nuot nuoc mat tan di trong tieng cuoi");
            Calc = (int a, int b, int c) => a + b+ c;
            Console.WriteLine(Calc(1,3,4));
        }

        Func<int, int, int, double>? Calc;

        ~Log()
        {
            Console.WriteLine("Hủy");
        }
    }
}
