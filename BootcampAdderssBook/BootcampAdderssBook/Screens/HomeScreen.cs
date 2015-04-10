using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Data;

namespace BootcampAdderssBook.Screens
{
    public class HomeScreen : Screen
    {
        public override void Display()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            
            Console.WriteLine("What would you like to do?");
            Console.WriteLine();
            Console.WriteLine("1) Load Contact from File");
            Console.WriteLine("2) Save Contact to File");
            Console.WriteLine("3) Set Contact Name");
            Console.WriteLine("4) Add Contact");
            Console.WriteLine("5) View Contact Details");
            Console.WriteLine("6) Order Contacts by First Name, Last Name, or Phone Number");
            Console.WriteLine();
            Console.WriteLine("Q) Quit, and go hangout with that person!");


            Screen nextStep = GetNextStep();
            if (nextStep != null)
                this.GoTo(nextStep);
        }

        private Screen GetNextStep()
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
                        return new LoadAddressScreen();
                    case '2':
                        return new SaveAddressScreen();
                    case '3':
                        return new SetAddressNameScreen();
                    case '4':
                        return new NewAddressScreen();
                    case '5':
                        return new SelectAddressScreen();
                    case '6':
                        return new SortingScreen();


                }
            }
        }
    }
}
