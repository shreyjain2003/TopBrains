using System;
using System.Text;
using System.Globalization;

namespace InventoryNameCleanup
{
    public class Program
    {
        /// <summary>
        /// Entry point of the application.
        /// Demonstrates inventory name cleanup.
        /// </summary>
        public static void Main()
        {
            string input = " llapppptop bag ";
            string result = CleanInventoryName(input);

            Console.WriteLine(result);
        }

        /// <summary>
        /// Cleans an inventory name by:
        /// 1. Removing duplicate consecutive characters
        /// 2. Trimming extra spaces
        /// 3. Converting the result to Title Case
        /// </summary>
        /// <param name="productName">Raw product name string</param>
        /// <returns>Cleaned product name in Title Case</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if the input string is null
        /// </exception>
        public static string CleanInventoryName(string productName)
        {
            if (productName == null)
                throw new ArgumentNullException(nameof(productName));

            // Step 1: Trim leading and trailing spaces
            productName = productName.Trim();

            // Step 2: Remove duplicate consecutive characters
            StringBuilder cleaned = new StringBuilder();
            char previousChar = '\0';

            foreach (char currentChar in productName)
            {
                if (currentChar != previousChar)
                {
                    cleaned.Append(currentChar);
                    previousChar = currentChar;
                }
            }

            // Step 3: Normalize spaces (remove extra spaces between words)
            string normalized = string.Join(
                " ",
                cleaned.ToString().Split(' ', StringSplitOptions.RemoveEmptyEntries)
            );

            // Step 4: Convert to Title Case
            TextInfo textInfo = CultureInfo.InvariantCulture.TextInfo;
            return textInfo.ToTitleCase(normalized.ToLower());
        }
    }
}
