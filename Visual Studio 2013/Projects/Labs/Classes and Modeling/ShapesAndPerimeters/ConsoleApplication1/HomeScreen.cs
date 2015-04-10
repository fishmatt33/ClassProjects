using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class HomeScreen
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What shpe would you like to work with?");
            Console.WriteLine();
            Console.WriteLine("1) Rectangle");
            Console.WriteLine("2) Triangle");
            Console.WriteLine("3) Circle");
            Console.WriteLine("Q) Quit, and go away");
            Console.ReadLine();
            
        }

        private Shape GetNextStep()
        {
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.KeyChar)
                {
                    case 'Q':
                    case 'q':
                        return null;
                    case '1':
                        return new Rectangle();
                    case '2':
                        return new Triangle();
                    case '3':
                        return new Circle();
                    
                }
            }
        }
    }
}
