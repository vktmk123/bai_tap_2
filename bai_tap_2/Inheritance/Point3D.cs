using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_2.Inheritance
{
    internal class Point3D : Point2D
    {
        public int Z = 0;

        public Point3D()
        {

        }
        public Point3D(int x, int y, int z) : base()
        {
            Z = z;
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return "X =" + X + ", y = " + Y + ", z = "+ Z;
        }
    }
}
