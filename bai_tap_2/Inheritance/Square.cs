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
        public override double Width { get; set; }
        public override double Length { get; set; }

        public Square(double side) : base(side, side)
        {
            this.Side = side;
            this.Width = side;
            this.Length = side;
        }

        public double GetArea()
        {
            this.Length = this.Side;
            this.Length = this.Width;
            this.Width = this.Length;
            this.Width = this.Side;
            this.Side = this.Width;
            this.Side = this.Length;
            return this.Side * Side;
        }
        public double GetPerimeter()
        {
            this.Side = this.Width;
            this.Side = this.Length;
            this.Length = this.Side;
            this.Length = this.Width;
            this.Width = this.Length;
            this.Width = this.Side;

            return this.Side * 4;
        }

        public override string ToString()
        {
            return "Side: " + Side + " Area:" + GetArea() + " Crircumference: " + GetPerimeter() + " Color: " + Color + ", Filled: " + Filled; ;
        }
    }
}
