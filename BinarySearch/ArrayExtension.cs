using System;
using System.Collections.Generic;

namespace BinarySearch
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Search lowest index of element that is equel to obj by comparer.
        /// </summary>
        /// <typeparam name="TSource">Base type of array.</typeparam>
        /// <param name="source">Source array.</param>
        /// <param name="obj">Element to search.</param>
        /// <param name="comparer">An <see cref="IComparer{T}"/> to compare elements.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Thrown when array or obj or comparer is null.</exception>
        public static int? Search<TSource>(this TSource[] source, TSource obj, IComparer<TSource> comparer)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (obj == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (comparer == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            int left = 0;
            int right = source.Length - 1;
            while (left < right)
            {
                if (comparer.Compare(source[(left + right) / 2], obj) < 0)
                {
                    left = ((left + right) / 2) + 1;
                }
                else
                {
                    right = (left + right) / 2;
                }
            }

            if (source.Length != 0 && comparer.Compare(source[right], obj) == 0)
            {
                return right;
            }
            else
            {
                return null;
            }
        }
    }
}
