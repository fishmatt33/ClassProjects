using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounting.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sequence");
            string sentanceString = Console.ReadLine();
            int wordcounter = 1;

            foreach (char word in sentanceString)
            {
                if (char.IsWhiteSpace(word))
                {
                    wordcounter++;
                }
            }
            Console.WriteLine("Your sentance contains {0} words", wordcounter);
            Console.ReadLine();
        }
    }
}
