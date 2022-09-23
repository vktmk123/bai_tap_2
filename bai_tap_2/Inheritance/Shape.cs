using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_2.Inheritance
{
    internal class Shape
    {
        public string Color = "red";
        public bool Filled = true;

        public Shape()
        {

        }
        public Shape(string color, bool filled)
        {
            Color = color;
            Filled = filled;
        }
        public override string ToString()
        {
            return "Color: "+ Color + ", Filled: " + Filled;   
        }

    }
}
