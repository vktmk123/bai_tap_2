using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_2.Polymorphism
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public Rectangle(string color, double width, double length) : base(color) 
        {
            Width = width;
            Length = length;
            Color = color;
        }
        public override string ToString()
        {
            return "Rectangle Triangle = " + getArea() + ", Color = " + Color;
        }
    }
}
