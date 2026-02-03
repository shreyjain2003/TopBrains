using ShapeAreaApp.Interfaces;

namespace ShapeAreaApp.Models
{
    /// <summary>
    /// Abstract base class for all shapes.
    /// </summary>
    public abstract class Shape : IArea
    {
        /// <summary>
        /// Calculates the area of the shape.
        /// </summary>
        /// <returns>Area as double</returns>
        public abstract double CalculateArea();
    }
}
