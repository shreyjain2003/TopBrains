namespace ShapeAreaApp.Models
{
    /// <summary>
    /// Represents a rectangle shape.
    /// </summary>
    public class Rectangle : Shape
    {
        private readonly double _width;
        private readonly double _height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public override double CalculateArea()
        {
            return _width * _height;
        }
    }
}
