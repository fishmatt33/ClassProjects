using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Data;
using AddressBook.Models;

namespace BootcampAdderssBook.Screens
{
    public abstract class SortingOptionsScreen : Screen
    {
        public AddressValues Contactee { get; private set; }

        public override void Display()
        {
            Console.WriteLine
                   ("Please enter your sorting choice:\n(F)irst Name, (L)ast Name, or (P)hone Number");

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.KeyChar)
                {
                    case 'F':
                    case 'f':
                        this.GoTo(new EditAddressScreen(Contactee));
                        break;
                    case 'L':
                    case 'l':
                        AddressBook.Data.ContactList.CurrentContactList.Contacts.Remove(Contactee);
                        return;
                    case 'P':
                    case 'p':
                        return;
                }
            }
        }
    }
}
