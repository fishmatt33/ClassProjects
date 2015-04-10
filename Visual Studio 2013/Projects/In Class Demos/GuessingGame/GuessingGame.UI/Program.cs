using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rand = new Random();
            int theAnswer = rand.Next(1, 21);

            int guesses = 0;
            
            bool isCorrect = false;

            Console.WriteLine("Welcome to the guessing game. Enter Your Name");
            string playerName = Console.ReadLine();

            do
            {
                Console.Write("Enter Your Guess {0} or press q to quit:", playerName);
                string playerGuess = Console.ReadLine();
            
                int guessNum;
                bool isANumber = int.TryParse(playerGuess, out guessNum);
                
                if (playerGuess == "q")
                    break;

                if (isANumber)
                {
                    guesses++;

                    if ((guesses == 1) && (guessNum == theAnswer))
                    {
                        Console.WriteLine("Amazing, you got it on the first try!");
                        isCorrect = true;
                    }

                    else if (guessNum == theAnswer)
                    {
                        Console.WriteLine("You did it! Way to go!");
                        isCorrect = true;
                    }

                    else if (guessNum > 21)
                        Console.WriteLine("That is too high of a number {0}!:", playerName);
                    else if (guessNum > theAnswer)
                        Console.WriteLine("Too High {0}!: ", playerName);
                    else if (guessNum < theAnswer)
                        Console.Write("Too low {0}!:", playerName);

                    Console.WriteLine("Number of guesses: {0}", guesses);
                }
            
                else 
                        Console.WriteLine("That's not a number, dummy");
                
            }
            while (!isCorrect);
            Console.WriteLine("Press enter to quit.");
            Console.ReadLine();
        }

    }
}
