using System;
using System.Collections.Generic;

namespace Blazor.WASM.Services
{
    static class TestWhere
    {
        public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            List<TSource> sourceReturn = new List<TSource>();
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    sourceReturn.Add(item);
                }
            }
            return sourceReturn;
        }
    }
}
