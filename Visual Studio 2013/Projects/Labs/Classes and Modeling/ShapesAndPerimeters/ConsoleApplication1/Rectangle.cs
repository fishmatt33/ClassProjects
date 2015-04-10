using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApplication1
{
    public class Rectangle : Shape
    {
         double length;
         double width;
        
        public void AcceptParameters()
        {
            Console.Write("Please enter a length:");
            length = int.Parse(Console.ReadLine());

            Console.Write("Please enter a width:");
            width = int.Parse(Console.ReadLine());

        }

        public double GetArea()
        {
            return length*width;
        }

        public double GetPerimeter()
        {
            return (2*length) + (2*width);
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
            Console.WriteLine("Perimeter: {0}", GetPerimeter());

        }

    }
}
