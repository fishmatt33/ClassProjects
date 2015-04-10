using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringCalculator.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the flooring calculator.");
            Console.ReadLine();

            Console.WriteLine("This console will calculate the square footage of a room, the cost for flooring per square foot at $2 per foot, and the time to install the flooring at 20 square feet per hour");
            Console.ReadLine();
            
            Console.WriteLine("Please enter the width");
            var userWidth = Console.ReadLine();
            int width = int.Parse(userWidth);

            Console.WriteLine("Please enter a length");
            var userLength = Console.ReadLine();
            int length = int.Parse(userLength);
            
            decimal areaOfRoom = width * length;
            decimal costPer = (areaOfRoom * 2);
            decimal labor = (areaOfRoom / 20);
            decimal laborCost = (labor * 86);
            Console.WriteLine("The area of the room is " + areaOfRoom + " square feet. The cost per square foor is $"
                              + costPer + ". The crew can install the flooring in " + labor + "hours. The labor cost is $"
                              + laborCost + " per square foot.");
            Console.ReadLine();
            
        }
    }
}
