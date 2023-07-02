using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NetFundamental.MultiThreading
{
    internal class DownloadWebsite
    {
        public static string DownloadWebpage(string url, bool showResult)
        {
            using (var client = new WebClient())
            {
                Console.Write("Starting download ...");
                string content = client.DownloadString(url);
                if (showResult)
                {
                    Console.WriteLine(content.Substring(0, 150));
                }
                return content;
            }
        }

        public static void Test()
        {
            string url = "https://code.visualstudio.com/";
            DownloadWebpage(url, true);
            Console.WriteLine("Do somthing ...");
        }
    }
}
