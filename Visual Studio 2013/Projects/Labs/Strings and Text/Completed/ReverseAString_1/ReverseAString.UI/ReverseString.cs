using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAString.UI
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Please enter a few characters and they will return in reverse");
            string userInput = Console.ReadLine();

            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                
                Console.Write(userInput[i]);
            }
            
            Console.ReadLine();



        }
    }
}
