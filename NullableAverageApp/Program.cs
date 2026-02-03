using System;

namespace NullableAverageApp
{
    /// <summary>
    /// Entry point class for computing the average of non-null values
    /// from a nullable double array.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Application entry point.
        /// </summary>
        /// <param name="args">Command-line arguments</param>
        static void Main(string[] args)
        {
            // Sample input array (nullable double array)
            double?[] values = { 10.125, null, 20.235, null, 30.555 };

            // Call method to compute average
            double? average = ComputeAverage(values);

            // Display result
            if (average.HasValue)
            {
                Console.WriteLine($"Average: {average.Value}");
            }
            else
            {
                Console.WriteLine("Average: null");
            }
        }

        /// <summary>
        /// Computes the average of non-null values in a nullable double array.
        /// - Ignores null values
        /// - Returns null if there are no non-null values
        /// - Rounds result to 2 decimal places using AwayFromZero rounding
        /// </summary>
        /// <param name="values">Array of nullable double values</param>
        /// <returns>Nullable double representing the average</returns>
        public static double? ComputeAverage(double?[] values)
        {
            // Validate input
            if (values == null || values.Length == 0)
                return null;

            double sum = 0;
            int count = 0;

            // Iterate through array and accumulate non-null values
            foreach (double? value in values)
            {
                if (value.HasValue)
                {
                    sum += value.Value;
                    count++;
                }
            }

            // If no valid values exist, return null
            if (count == 0)
                return null;

            // Calculate average
            double average = sum / count;

            // Round to 2 decimal places (AwayFromZero)
            return Math.Round(average, 2, MidpointRounding.AwayFromZero);
        }
    }
}
