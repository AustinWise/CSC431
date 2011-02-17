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

        public static IEnumerable<int> TrueIndexs(this BitArray arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i])
                    yield return i;
            }
        }
    }
}
