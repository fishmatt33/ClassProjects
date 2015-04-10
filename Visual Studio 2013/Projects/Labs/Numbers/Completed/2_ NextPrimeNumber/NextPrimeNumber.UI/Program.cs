using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextPrimeNumber.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string userNumber = Console.ReadLine();
            int newNumber = int.Parse(userNumber);
            
            bool isPrimeNumberFound = true;
            bool isNextPrimeNumberFound = false;

            //Get Square root of number and iterate, start from 2
            int check = (int)Math.Sqrt((double)(newNumber));
            for (int j = 2; j <= check; j++)
            {
                if (newNumber % j == 0)
                {
                    isPrimeNumberFound = false;
                    break;
                }
            }
            if (isPrimeNumberFound)
            {
                Console.WriteLine(newNumber + " is a prime number");

            }
            else
            {
                Console.WriteLine(newNumber + " is not a prime number");
            }
            newNumber++;
            isPrimeNumberFound = true;
            // Increment current number to find next prime number
            while (isNextPrimeNumberFound == false)
            {
                check = (int)Math.Sqrt((double)(newNumber));
                for (int j = 2; j <= check; j++)
                {
                    if (newNumber % j == 0)
                    {
                        isPrimeNumberFound = false;
                        break;
                    }
                }
                if (isPrimeNumberFound)
                {
                    isNextPrimeNumberFound = true;
                }
                else
                {
                    newNumber++; isPrimeNumberFound = true;
                }
            }

            if (isNextPrimeNumberFound) 
            { 
                Console.WriteLine(newNumber + " is the next prime number"); 
            }
            Console.ReadLine();
        }


    }
}
