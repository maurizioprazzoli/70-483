using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinq
{
    internal static class CustomLinq
    {
        public static IEnumerable<TIn> CustomWhere<TIn>(this IEnumerable<TIn> inList, Func<TIn,bool> filterFunction)
        {
            foreach (var element in inList)
            {
                if (filterFunction(element))
                {
                    yield return element;
                }
            }
        }

    }
}
