namespace ShapeAreaApp.Models
{
    /// <summary>
    /// Represents a triangle shape.
    /// </summary>
    public class Triangle : Shape
    {
        private readonly double _base;
        private readonly double _height;

        public Triangle(double baseValue, double height)
        {
            _base = baseValue;
            _height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * _base * _height;
        }
    }
}
