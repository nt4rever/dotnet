using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFundamental
{
    internal class MyArray
    {
        public static int Count<T>(T[] array)
        {
            return array.Length;
        }

        public static int IndexOf<T>(T[] array, T value)
        {
            for (int i = 0; i < array.Length; i++)
                if (value != null && value.Equals(array[i]))
                    return i;
            return -1;
        }

        public static void ForEach<T>(T[] array, Action<T, int> callback)
        {
            for (int i = 0; array.Length > i; i++)
                callback(array[i], i);
        }

        public static dynamic Reduce<T>(T[] array, Func<T, T> callback, dynamic defaultValue)
        {
            dynamic accumulate = defaultValue;
            for (int i = 0; i < array.Length; i++)
                accumulate += callback(array[i]);
            return accumulate;
        }

        public static T[] Map<T>(T[] array, Func<T, T> callback)
        {
            T[] newArray = new T[array.Length];
            for (int i = 0; i < array.Length; ++i)
                newArray[i] = callback(array[i]);
            return newArray;
        }
    }
}
