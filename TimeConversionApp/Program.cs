using System;

namespace TimeConversionApp
{
    /// <summary>
    /// Entry point class for converting seconds into m:ss format.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Application entry point.
        /// </summary>
        /// <param name="args">Command-line arguments</param>
        static void Main(string[] args)
        {
            // Sample inputs
            int totalSeconds1 = 125;
            int totalSeconds2 = 60;

            // Convert seconds to formatted time
            string result1 = ConvertSeconds(totalSeconds1);
            string result2 = ConvertSeconds(totalSeconds2);

            // Display results
            Console.WriteLine($"{totalSeconds1} -> \"{result1}\"");
            Console.WriteLine($"{totalSeconds2} -> \"{result2}\"");
        }

        /// <summary>
        /// Converts a given number of seconds into a string formatted as m:ss.
        /// - Minutes are calculated using integer division.
        /// - Seconds are always displayed as two digits (leading zero if needed).
        /// </summary>
        /// <param name="totalSeconds">Total number of seconds (>= 0)</param>
        /// <returns>Formatted time string in m:ss format</returns>
        public static string ConvertSeconds(int totalSeconds)
        {
            // Guard clause for non-negative constraint
            if (totalSeconds < 0)
                throw new ArgumentException("Total seconds cannot be negative.");

            // Calculate minutes and remaining seconds
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;

            // Format seconds with leading zero if required
            return $"{minutes}:{seconds:D2}";
        }
    }
}
