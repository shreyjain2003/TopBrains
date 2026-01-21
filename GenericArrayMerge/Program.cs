using System;

namespace GenericArrayMerge
{
    public class Program
    {
        /// <summary>
        /// Entry point of the application.
        /// Demonstrates merging two sorted arrays.
        /// </summary>
        public static void Main()
        {
            int[] a = { 1, 3, 5, 7 };
            int[] b = { 2, 4, 6, 8 };

            int[] merged = MergeSortedArrays(a, b);

            Console.WriteLine("Merged Array:");
            foreach (var item in merged)
            {
                Console.Write(item + " ");
            }
        }

        /// <summary>
        /// Merges two already sorted arrays into a single sorted array.
        /// </summary>
        /// <typeparam name="T">
        /// The type of elements in the arrays.
        /// Must implement IComparable&lt;T&gt;.
        /// </typeparam>
        /// <param name="a">First sorted array</param>
        /// <param name="b">Second sorted array</param>
        /// <returns>A new sorted array containing all elements from both arrays</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if either input array is null
        /// </exception>
        public static T[] MergeSortedArrays<T>(T[] a, T[] b)
            where T : IComparable<T>
        {
            if (a == null)
                throw new ArgumentNullException(nameof(a));

            if (b == null)
                throw new ArgumentNullException(nameof(b));

            int n = a.Length;
            int m = b.Length;

            // Result array with total size
            T[] merged = new T[n + m];

            int i = 0, j = 0, k = 0;

            // Merge elements while both arrays have elements
            while (i < n && j < m)
            {
                if (a[i].CompareTo(b[j]) <= 0)
                {
                    merged[k++] = a[i++];
                }
                else
                {
                    merged[k++] = b[j++];
                }
            }

            // Copy remaining elements from array a
            while (i < n)
            {
                merged[k++] = a[i++];
            }

            // Copy remaining elements from array b
            while (j < m)
            {
                merged[k++] = b[j++];
            }

            return merged;
        }
    }
}
