using System;

namespace DisplayHeight
{
    /// <summary>
    /// This program categorizes a person's height into Short, Average, or Tall based on the input height in centimeters.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Categorizes height into Short, Average, or Tall.
        /// </summary>
        /// <param name="height">The height of the person in centimeters.</param>
        /// <returns>A string representing the height category: "Short", "Average", "Tall", or "Invalid height".</returns>
    public static string DisplayHeightCategory(int height)
    {
        if(height < 150)
        {
            return "Short";
        }
        else if(height >=150 && height <180)
        {
            return "Average";
        }
        else if(height >=180 && height <=300)
        {
            return "Tall";
        }
        else
        {
            return "Invalid height";
        }
    }

    public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Height (in cm): ");
            int height=int.Parse(Console.ReadLine());

            string result=DisplayHeightCategory(height);
            Console.WriteLine(result);
        }
    }
}