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

        public static void AddEnsuringList<K, V>(this Dictionary<K, List<V>> dic, K key, V value)
        {
            if (!dic.ContainsKey(key))
                dic.Add(key, new List<V>());
            dic[key].Add(value);
        }

        public static V? GetMaybeNull<K, V>(this Dictionary<K, V> dic, K key) where V : struct
        {
            if (dic.ContainsKey(key))
                return dic[key];
            return null;
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

        /// <summary>
        /// THIS RETURNS 0 IF THERE ARE NO TRUE INDEXES, BE SURE YOU WANT THAT.
        /// </summary>
        /// <param name="ar"></param>
        /// <returns></returns>
        public static int FirstTrueIndex(this BitArray ar)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i])
                    return i;
            }
            return 0;
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

        public static int NumberOfBitsSet(this BitArray bar)
        {
            var ar = new int[bar.IntArraySize()];
            bar.CopyTo(ar, 0);
            int numSet = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == 0)
                    continue;
                numSet += numberOfSetBits(ar[i]);
            }
            return numSet;
        }

        private static int numberOfSetBits(int i)
        {
            i = i - ((i >> 1) & 0x55555555);
            i = (i & 0x33333333) + ((i >> 2) & 0x33333333);
            return ((i + (i >> 4) & 0xF0F0F0F) * 0x1010101) >> 24;
        }
    }
}
