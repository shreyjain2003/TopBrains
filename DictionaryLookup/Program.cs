using System;
using System.Collections.Generic;

namespace DictionaryLookup
{
    public class Program
    {
        /// <summary>
        /// Entry point of the application.
        /// Demonstrates dictionary lookup and salary aggregation.
        /// </summary>
        public static void Main()
        {
            Dictionary<int, int> salaryDictionary = new Dictionary<int, int>
            {
                { 1, 20000 },
                { 4, 40000 },
                { 5, 15000 }
            };

            int[] employeeIds = { 1, 4, 5 };

            int totalSalary = GetTotalSalary(employeeIds, salaryDictionary);

            Console.WriteLine(totalSalary);
        }

        /// <summary>
        /// Calculates the total salary for the given list of employee IDs
        /// using the provided salary dictionary.
        /// </summary>
        /// <param name="employeeIds">Array of employee IDs</param>
        /// <param name="salaryMap">Dictionary mapping EmployeeId to Salary</param>
        /// <returns>Total salary of the given employee IDs</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if employeeIds or salaryMap is null
        /// </exception>
        public static int GetTotalSalary(int[] employeeIds, Dictionary<int, int> salaryMap)
        {
            if (employeeIds == null)
                throw new ArgumentNullException(nameof(employeeIds));

            if (salaryMap == null)
                throw new ArgumentNullException(nameof(salaryMap));

            int total = 0;

            // Lookup salary for each employee ID
            foreach (int id in employeeIds)
            {
                if (salaryMap.TryGetValue(id, out int salary))
                {
                    total += salary;
                }
            }
            return total;
        }
    }
}
