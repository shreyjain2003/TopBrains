using System;

namespace ShapeAreaApp.Models
{
    /// <summary>
    /// Represents a circle shape.
    /// </summary>
    public class Circle : Shape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
