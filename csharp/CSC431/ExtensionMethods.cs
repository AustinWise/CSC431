using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CSC431
{
    public static class ExtensionMethods
    {
        public static void Map<T>(this IEnumerable<T> list, Action<T> act)
        {
            foreach (var i in list)
            {
                act(i);
            }
        }

        public static int MaxIndex<T>(this List<T> list, Func<T, int> maxFunction)
        {
            int loc = -1;
            int maxValue = int.MinValue;

            for (int i = 0; i < list.Count; i++)
            {
                int newMaxVal = maxFunction(list[i]);
                if (newMaxVal > maxValue)
                {
                    loc = i;
                    maxValue = newMaxVal;
                }
            }

            return loc;
        }

        public static IEnumerable<int> TrueIndexs(this BitArray arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i])
                    yield return i;
            }
        }

        public static int IntArraySize(this BitArray ar)
        {
            int n = ar.Length;
            if (n <= 0)
            {
                return 0;
            }
            return (((n - 1) / 0x20) + 1);
        }
    }
}
