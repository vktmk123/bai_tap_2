using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_2.Inheritance
{
    internal class Point2D
    {
        public int X = 0;
        public int Y = 0;
        public Point2D()
        {

        }
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return "X =" + X + ", y = " + Y;
        }
    }
}
