using bai_tap_2.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_2
{
    internal class Cirecle : Shape
    {
        public double Radius = 1.0;

        public Cirecle()
        {

        }
        public Cirecle(double radius, string color, bool filled) : base(color, filled)
        {
            Radius = radius;
            Color = color;
            Filled = filled;
        }
        public double GetArea()
        {
            return Radius * Radius * Math.PI;
        }
        public double GetPerimeter()
        {
            return 2 * Radius * Math.PI;
        }
        public override string ToString()
        {
            return "Radius: " + Radius + " Area:" + GetArea() + " Crircumference: " + GetPerimeter()+ " Color: " + Color + ", Filled: " + Filled; ;
        }
    }
}
