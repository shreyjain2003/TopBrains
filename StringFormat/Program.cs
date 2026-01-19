using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text.Json;

namespace StringFormat
{

/// <summary>
/// Student Record Type
/// </summary>
/// <param name="Name">The name of the student.</param>
/// <param name="Score">The score of the student.</param>
    public record Student(string Name,int Score);
    public class Program
    {
        /// <summary>
        /// Builds a JSON string of students who have scores greater than or equal to the specified minimum score.
        /// </summary>
        /// <param name="items">An array of strings representing student records in the format "Name:Score".</param>
        /// <param name="minScore">The minimum score threshold for including students in the JSON output.</param>
        /// <returns>A JSON string representing the list of students who meet the minimum score criteria.</returns>
        public static string BuildStudentJson(string[] items, int minScore)
        {
            var students=new List<Student>(items.Length);
            
            foreach(var item in items)
            {
                var parts=item.Split(':');

                if(parts.Length!=2)
                continue;

                if(!int.TryParse(parts[1],out int score))
                {
                    continue;
                }

                if(score >=minScore)
                {
                    students.Add(new Student(parts[0],score));
                }
            }

            var result=students.OrderByDescending(s => s.Score)      // Sort by Score in descending order
                                 .ThenBy(s => s.Name)               // Then sort by Name in ascending order
                                 .ToList();
            return JsonSerializer.Serialize(result);
        }
        public static void Main(string[] args)
        {
            // Sample input data
            string[] items=
            {
                "Shrey:95",
                "Tushar:90",
                "Sahaj:99",
                "Apurav:80",
                "Raj:82"
            };

            int minScore=88;

            string json=BuildStudentJson(items,minScore);
            Console.WriteLine(json);
        }
    }
}