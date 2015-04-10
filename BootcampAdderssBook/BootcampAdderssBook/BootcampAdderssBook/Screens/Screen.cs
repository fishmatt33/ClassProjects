using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Data;

namespace BootcampAdderssBook.Screens
{
    public abstract class Screen
    {
        public abstract void Display();

        public void Run()
        {
            this.DisplayHeader();
            this.Display();
        }

        public void DisplayHeader()
        {
            Console.Clear();
            Console.WriteLine("Bootcamp Address Book");
            string displayName = Address.CurrentAddress.AddressName != null
                ? Address.CurrentAddress.AddressName
                : "\nContact";
            Console.WriteLine("{0} ({1} Addresses)\n", displayName, Address.CurrentAddress.Contact.Count);
            Console.WriteLine();
        }

        public void GoTo(Screen nextScreen)
        {
            nextScreen.Run();
            this.Run();
        }
    }
}
