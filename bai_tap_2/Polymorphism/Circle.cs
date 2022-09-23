using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_2.Polymorphism
{
    internal class Circle
    {
        public double Radius { get; private set; }

        public Circle()
        {
            Radius = 4;
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public virtual double GetAraea()
        {
            return Radius * Radius * Math.PI;
        }
        public override string ToString()
        {
            return "Circle = "+ Radius + ", Araea = " + GetAraea();
        }
    }
}
