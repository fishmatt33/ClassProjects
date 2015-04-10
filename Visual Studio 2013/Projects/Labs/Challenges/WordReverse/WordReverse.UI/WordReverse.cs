using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WordReverse.UI
{
    //Given a string containing a sentence, reverse the characters of each word, but not the string itself.
    //ex: "I am a human being" -> "I ma a namuh gnieb"
    //public class WordReverse
    //{
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter a few words to have them reversed");
            string userInput = Console.ReadLine();

            //var reversedWords = string.Join(" ",
            //userInput.Split(' ')
            //.Select(x => new String(x.Reverse().ToArray()))
            //.ToArray());

            //foreach (var r in reversedWords)
            //{
            //    Console.WriteLine(reversedWords);
            //}
            //Console.ReadLine();

            char[] chars = userInput.ToCharArray();
            Array.Reverse(chars);
            return new string (chars);


        }
    }
}
