using System;
using ShapeAreaApp.Models;

/// <summary>
/// Entry point for computing total area of shapes defined by strings.
/// </summary>
namespace ShapeAreaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sample input
            string[] shapes =
            {
                "C 10",
                "R 5 4",
                "T 6 3"
            };

            double totalArea = ComputeTotalArea(shapes);

            Console.WriteLine($"Total Area: {totalArea}");
        }

        /// <summary>
        /// Computes the total area of shapes described in string format.
        /// </summary>
        /// <param name="shapes">Array of shape description strings</param>
        /// <returns>Total area rounded to 2 decimals</returns>
        public static double ComputeTotalArea(string[] shapes)
        {
            if (shapes == null || shapes.Length == 0)
                return 0;

            double totalArea = 0;

            foreach (string shapeStr in shapes)
            {
                if (string.IsNullOrWhiteSpace(shapeStr))
                    continue;

                string[] parts = shapeStr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Shape shape = null;

                switch (parts[0])
                {
                    case "C": // Circle
                        shape = new Circle(double.Parse(parts[1]));
                        break;

                    case "R": // Rectangle
                        shape = new Rectangle(
                            double.Parse(parts[1]),
                            double.Parse(parts[2])
                        );
                        break;

                    case "T": // Triangle
                        shape = new Triangle(
                            double.Parse(parts[1]),
                            double.Parse(parts[2])
                        );
                        break;
                }

                if (shape != null)
                {
                    totalArea += shape.CalculateArea();
                }
            }

            // Round final result
            return Math.Round(totalArea, 2, MidpointRounding.AwayFromZero);
        }
    }
}
