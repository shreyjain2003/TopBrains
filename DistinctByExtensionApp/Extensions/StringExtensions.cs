using System.Collections.Generic;

namespace DistinctByExtensionApp.Extensions
{
    /// <summary>
    /// Contains custom extension methods for string collections.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Returns names for the first occurrence of each distinct id.
        /// Input strings must be in the format "id:name".
        /// Order of first appearance is preserved.
        /// </summary>
        /// <param name="items">Array of strings in "id:name" format</param>
        /// <returns>Array of distinct names based on id</returns>
        public static string[] DistinctById(this string[] items)
        {
            if (items == null || items.Length == 0)
                return new string[0];

            HashSet<string> seenIds = new HashSet<string>();
            List<string> result = new List<string>();

            foreach (string item in items)
            {
                if (string.IsNullOrWhiteSpace(item))
                    continue;

                // Split input string into id and name
                string[] parts = item.Split(':');

                if (parts.Length != 2)
                    continue;

                string id = parts[0];
                string name = parts[1];

                // Add only if id has not appeared before
                if (seenIds.Add(id))
                {
                    result.Add(name);
                }
            }

            return result.ToArray();
        }
    }
}
