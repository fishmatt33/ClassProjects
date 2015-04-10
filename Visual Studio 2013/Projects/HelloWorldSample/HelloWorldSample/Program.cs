using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldSample
{
    class Program // Define our class
    {
        static void Main(string[] args) //start point of application
        {
            int myInt = HelloWorld.Solution.UserInput.GetInt32("Enter a number: ");
            Console.ReadLine();

        }
    }
}
