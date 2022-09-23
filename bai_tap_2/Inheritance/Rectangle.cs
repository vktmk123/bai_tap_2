using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_2.Inheritance
{
    internal class Rectangle : Shape
    {
        public virtual double Width { get; set; }
        public virtual double Length { get; set; }
        public Rectangle()
        {
            Width = 1.0;
            Length = 1.0;
        }
        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }
        public Rectangle(double width, double length, string color, bool filled) : base(color, filled)
        {
            Width = width;
            Length = length;
            Color = color;
            Filled = filled;
        }
        public double GetArea()
        {
            return Width * Length;
        }
        public double GetPerimeter()
        {
            return (Width + Length) * 2;
        }
        public override string ToString()
        {
            return "Width: " + Width + " Length: "+ Length + " Area:" + GetArea() + " Crircumference: " + GetPerimeter() + " Color: " + Color + ", Filled: " + Filled; ;
        }
    }
}
