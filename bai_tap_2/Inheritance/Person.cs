using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_2.Inheritance
{
    public class Person
    {
        public string Address { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return "Name = " + Name + "Address = " + Address;
        }
    }
}
