using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Triangle : Shape
    {
        double tBase;
        double firstSide;
        double secondSide;

        public void AcceptParameters()
        {
            Console.WriteLine("Please enter a base");
            tBase = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the first side");
            firstSide = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second side");
            secondSide = int.Parse(Console.ReadLine());
        }

        public double GetArea()
        {
            return (tBase * firstSide)/2;
        }

        public double GetPerimeter()
        {
            return tBase + firstSide + secondSide;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", tBase);
            Console.WriteLine("Width: {0}", firstSide);
            Console.WriteLine("Area: {0}", GetArea());
            Console.WriteLine("Perimeter: {0}", GetPerimeter());
        }
    }
}
