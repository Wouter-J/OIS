using System;
using System.Collections.Generic;
using System.Linq;

namespace ATGM_Extensions
{
    /// <summary>
    /// Various small functions that help clean up code
    /// Additionally frequently used functions are added here as well
    /// All are generic.
    /// </summary>
    public static class GenericExtension
    {

        public static T Max<T>(T x, T y)
        {
            return (Comparer<T>.Default.Compare(x, y) > 0) ? x : y;
        }

        public static T Min<T>(T x, T y)
        {
            return (Comparer<T>.Default.Compare(x, y) < 0) ? x : y;
        }

        /// <summary>
        /// Generic in method, mostly used to shorten long if statements
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">item T that is being compared against</param>
        /// <param name="list">list of things to compare T to</param>
        /// <returns>true if item contains one of params in T; else an error. </returns>
        public static bool In<T>(this T source, params T[] list)
        {
            if (null == source) throw new ArgumentNullException("source");
            return list.Contains(source);
        }
    }
}
