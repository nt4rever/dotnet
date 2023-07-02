using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFundamental.MultiThreading
{
    internal class TestAsync
    {
        public static void WriteLine(string s, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(s);
        }

        public static Task<string> Async1(string thamso1, string thamso2)
        {
            Func<object, string> myFunc = (object thamso) =>
            {
                dynamic ts = thamso;
                for (int i = 1; i <= 10; i++)
                {
                    //  Thread.CurrentThread.ManagedThreadId  trả về ID của thread đạng chạy
                    WriteLine($"{i,5} {Thread.CurrentThread.ManagedThreadId,3} Tham số {ts.x} {ts.y}",
                        ConsoleColor.Green);
                    //Thread.Sleep(500);
                }
                return $"Kết thúc Async1! {ts.x}";
            };
            Task<string> task = new Task<string>(myFunc, new { x = thamso1, y = thamso2 });
            return task;
        }

        [Obsolete("Lac hau please")]
        public static async Task DemoToken()
        {
            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;
            Task task1 = new Task(() =>
            {
                for (int i = 0; i <= 10000; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("TASK1 STOP");
                        token.ThrowIfCancellationRequested();
                        return;
                    }
                    Console.WriteLine("TASK1 runing ... " + i);
                    Thread.Sleep(300);
                }
            }, token);

            // Tạo task1 có sử dụng CancellationToken
            Task task2 = new Task(
                () => {

                    for (int i = 0; i < 10000; i++)
                    {
                        if (token.IsCancellationRequested)
                        {
                            Console.WriteLine("TASK1 STOP");
                            token.ThrowIfCancellationRequested();
                            return;
                        }
                        Console.WriteLine("TASK2 runing ... " + i);
                        Thread.Sleep(300);
                    }
                },
                token
            );

            task1.Start();
            task2.Start();
            while(true)
            {
                var c = Console.ReadKey().KeyChar;

                // Nếu bấm e sẽ phát yêu cầu dừng task
                if (c == 'e')
                {
                    // phát yêu cầu dừng task
                    tokenSource.Cancel();
                    break;
                }
            }
            Console.WriteLine("Các task đã kết thúc, bấm phím bất kỳ kết thúc chương trình");
        }
    }
}
