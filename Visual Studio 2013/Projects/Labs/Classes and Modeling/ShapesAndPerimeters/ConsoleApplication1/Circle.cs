using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApplication1
{
    public class Circle : Shape
    {
        private double radius;

        public void AcceptParameters()
        {
            Console.WriteLine("Please enter the radius of a circle");
            radius = int.Parse(Console.ReadLine());
        }

        public double GetArea()
        {
            return Math.PI*(Math.Pow(radius, 2));
        }

        public double GetCircumference()
        {
            return Math.PI*(radius * 2);
        }

        public void Display()
        {
            Console.WriteLine("Area: {0}", GetArea());
            Console.WriteLine("Circumference: {0}", GetCircumference());
        }
    }
}
