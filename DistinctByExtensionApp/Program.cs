using System;
using DistinctByExtensionApp.Extensions;

namespace DistinctByExtensionApp
{
    /// <summary>
    /// Entry point for demonstrating custom DistinctBy extension method.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Application entry point.
        /// </summary>
        /// <param name="args">Command-line arguments</param>
        static void Main(string[] args)
        {
            // Sample input
            string[] items =
            {
                "1:Alice",
                "2:Bob",
                "1:Charlie",
                "3:David",
                "2:Eve"
            };

            // Call extension method
            string[] distinctNames = items.DistinctById();

            // Display output
            Console.WriteLine("Distinct Names:");
            foreach (string name in distinctNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
