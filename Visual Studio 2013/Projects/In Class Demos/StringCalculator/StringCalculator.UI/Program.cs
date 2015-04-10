using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to StringCalculator!  Enter some numbers.");
            Console.WriteLine("Enter 'quit' to quit.");

            while (true)

            {
                string input = Console.ReadLine();

                if (input == "quit")
                {
                    return;
                }

                Calculator calc = new Calculator();
                int result = calc.Add(input);
                Console.WriteLine("Result: {0}", result);
            }
        }
    }
}
