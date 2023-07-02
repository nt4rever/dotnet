using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFundamental
{
    internal class ArrayPractice
    {
        static void TestForEach()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Array.ForEach(numbers, (x) =>
            {
                Console.WriteLine(x);
            });
        }

        public static void TestFindAll()
        {
            int[] numbers = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Predicate<int> predicate = (int number) =>
            {
                return number % 2 == 0;
            };
            int[] evenNumbers = Array.FindAll(numbers, predicate);
            Action<int> printNumber = (int number) => Console.WriteLine(number);
            Array.ForEach(evenNumbers, printNumber);
            int indices = Array.FindIndex(numbers, predicate);
            Console.WriteLine(indices.ToString());
        }
    }
}
