using bai_tap_2.Polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Shape s1 = new Rectangle("red", 4, 5); // Upcast
            //Console.WriteLine(s1); // Run Rectangle's toString()
            //Console.WriteLine("Area is " + s1.getArea()); // Run Rectangle's getArea()

            //Shape s2 = new Triangle("blue", 4, 5); // Upcast
            //Console.WriteLine(s2); // Run Triangle's toString()
            //Console.WriteLine("Area is " + s2.getArea()); // Run Triangle's getArea()

            Circle circle = new Circle(4);
            Console.WriteLine(circle);
            
            Cylinder cylinder = new Cylinder(5);
            Console.WriteLine(cylinder);

            Console.ReadLine();

        }
    }
}
