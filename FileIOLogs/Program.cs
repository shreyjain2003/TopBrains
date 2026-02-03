using System;
using System.IO;
using System.Collections.Generic;

/// <summary>
/// Reads a log file, filters ERROR logs, and writes them to a new file.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        string inputFile = "log.txt";
        string outputFile = "error.txt";

        try
        {
            // Check if input file exists
            if (!File.Exists(inputFile))
            {
                Console.WriteLine("log.txt file not found.");
                return;
            }

            // Read all lines from log.txt
            string[] lines = File.ReadAllLines(inputFile);

            List<string> errorLogs = new List<string>();

            // Filter only ERROR logs
            foreach (string line in lines)
            {
                if (line.Contains("ERROR"))
                {
                    errorLogs.Add(line);
                }
            }

            // Write ERROR logs to error.txt
            File.WriteAllLines(outputFile, errorLogs);

            Console.WriteLine("ERROR logs extracted successfully to error.txt");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
