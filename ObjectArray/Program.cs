using System;

namespace ObjectArray
{
    public class Program
    {
        /// <summary>
        /// Entry point of the application.
        /// Demonstrates summing integer values from an object array.
        /// </summary>
        public static void Main()
        {
            object[] values = { 10, "abc", null, true, 20, 5.5, 30 };

            int result = SumOnlyIntegers(values);

            Console.WriteLine(result);
        }

        /// <summary>
        /// Sums only the integer values from an object array.
        /// Non-integer and null values are ignored.
        /// </summary>
        /// <param name="values">Array containing mixed object types</param>
        /// <returns>Sum of all integer values in the array</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if the input array is null
        /// </exception>
        public static int SumOnlyIntegers(object[] values)
        {
            if (values == null)
                throw new ArgumentNullException(nameof(values));

            int sum = 0;

            // Pattern matching to extract integer values
            foreach (object value in values)
            {
                if (value is int x)
                {
                    sum += x;
                }
            }
            return sum;
        }
    }
}
