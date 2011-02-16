using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
