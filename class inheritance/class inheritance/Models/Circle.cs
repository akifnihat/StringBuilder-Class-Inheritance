
namespace class_inheritance.Models
{
    internal class Circle:Shape
    {
        public int Radius;

        public Circle(string color, int radius) : base(color)
        {
            Radius = radius;
            double calculatedArea = Math.PI * Math.Pow(radius, 2);
            Area = (int)calculatedArea;
        }

    }
}
