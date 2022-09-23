using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_2.Polymorphism
{
    internal class Shape
    {
        public string Color;

        public Shape(string color)
        {
            Color = color;
        }

        public virtual double getArea()
        {
            return 0;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
