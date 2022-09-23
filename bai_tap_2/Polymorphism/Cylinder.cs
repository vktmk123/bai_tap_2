using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_2.Polymorphism
{
    internal class Cylinder : Circle
    {
        public double Height { get; set; }

        public Cylinder() : base()
        {

        }
        public Cylinder(double height) : base()
        {
            Height = height;
        }
        public override double GetAraea() 
        {
            return 2 * Math.PI * Radius  * Height;
        }

        public double Getvolume()
        {
            return Math.PI * Radius * Radius * Height;
        }

        public override string ToString()
        {
            return "Cylinder {Radius = " + Radius + " Height = " + Height + ", Araea = " + GetAraea()+ "}";
        }
    }
}
