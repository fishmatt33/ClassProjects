using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonachiSequence.UI
{
    class FibonachiSequence
    {
        static void Main(string[] args)
        {
            /*Fibonacci Sequence
            Difficulty: 2
            Create a program that calculates the Fibonacci sequence up to the Nth term. Ask the user to enter the Nth term and have the program calculate the sequence until it has printed that many terms.
            Tips
            -------------------------------
            There are two main ways you will find people solving this problem. There is the recursion method (which is a nice example to learn about recursion but a horrible practical application to solve it) or using a simple loop that keeps track of the two previous numbers to add them together to find the next value in the sequence. This second method is the more efficient method for computing because it doesn?t require multiple calls going on the call stack.
            Added Difficulty
            -------------------------------
            Implement both methods*/
            
            int x = 0, y = 1, z=0, nth, i;
            Console.WriteLine("\n\nPlease Enter The Term Number:");
            nth = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= nth; i++)
            {
                z = x + y;
                x = y;
                y = z; 
            }
 
            Console.WriteLine("\nthe {0}th term of Fibonacci Series is is {1}\n\n\n", nth, z);
            Console.ReadLine();


        }
    }
}
