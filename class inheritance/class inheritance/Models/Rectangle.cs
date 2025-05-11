
namespace class_inheritance.Models
{
    internal class Rectangle:Shape
    {
        public int Length;
        public Rectangle(string color, int length) : base(color)
        {
            Length = length;
            Area = length * length;
        } 
    }
}
