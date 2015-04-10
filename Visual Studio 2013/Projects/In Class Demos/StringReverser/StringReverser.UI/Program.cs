using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverser.UI
{
    class Program
    {
        static void Main(string[] args)
        {

            while(true)
            {
                Console.WriteLine("Hello, please give me sometign to reverse 'quit' to exit.");
                string input = Console.ReadLine();

                if (String.Equals(input, "quit", StringComparison.OrdinalIgnoreCase))
                    break;

                //ReverseAndyMethod(input);
                //ReverseKelsey(input);
                ReverseAsArray(input);
            } 
           
            Console.WriteLine("OK, I'm out");
            Console.ReadLine();
        }

        private static void ReverseAsArray(string input)
        {
            char[] inputAsChars = input.ToCharArray();
            Array.Reverse(inputAsChars);
            Console.WriteLine(inputAsChars);
        }

        private static void ReverseKelsey(string input)
        {
            StringBuilder sb = new StringBuilder(input.Length);
            //string result = String.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
                //result += input[i];
            }
            Console.WriteLine(sb.ToString());
            //Console.WriteLine(result);
        }

        private static void ReverseAndyMethod(string input)
        {
            char[] reversed = new char[input.Length];
            int i = input.Length - 1;
            foreach (char c in input)
            {
                reversed[i] = c;
                i--;
            }
            Console.WriteLine(reversed);
        }
    }
}
