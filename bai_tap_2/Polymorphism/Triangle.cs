using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_2.Polymorphism
{
    internal class Triangle : Shape
    {
        public int Base { get; set; }
        public int Height { get; set; }

        public Triangle(string color, int Base, int height) : base(color)
        {
            this.Base = Base;
            this.Height = height;
            Color = color;
        }
        public override double getArea()
        {
            return this.Base * this.Height / 2;
        }

        public override string ToString()
        {
            return "Area Triangle = " + getArea() + ", Color = " + Color; 
        }
    }
}
