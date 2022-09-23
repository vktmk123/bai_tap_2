using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_2.Inheritance
{
    internal class Square : Rectangle
    {
        public double Side;
        public override double Width
        {
            get { return Side; }
            set { Side = value; }
        }
        public override double Length
        {
            get { return Side; }
            set { Side = value; }
        }

        public Square(double side) : base(side, side)
        {
            this.Side = side;
            this.Width = side;
            this.Length = side;
        }

        public double GetArea()
        {
            return this.Side * Side;
        }
        public double GetPerimeter()
        {
            return this.Side * 4;
        }

        public override string ToString()
        {
            return "Side: " + Side + " Area:" + GetArea() + " Crircumference: " + GetPerimeter() + " Color: " + Color + ", Filled: " + Filled; ;
        }
    }
}
