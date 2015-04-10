using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Data;
using AddressBook.Models;

namespace BootcampAdderssBook.Screens
{
    public class SortContactScreen : Screen
    {
                public AddressValues Contactee { get; private set; }

        public SortContactScreen(AddressValues contactee)
        {
            this.Contactee = contactee;
        }

        public override void Display()
        {
            Console.WriteLine("Contact First Name: {0}", Contactee.FirstName);
            Console.WriteLine("Add Contact to Last Name: {0}", Contactee.LastName);
            Console.WriteLine("Address: {0}", Contactee.Address);
            Console.WriteLine("E-mail: {0}", Contactee.Email);
            Console.WriteLine("Phone Number: {0}", Contactee.PhoneNumber);

            Console.WriteLine("(E)dit, (D)elete, or (R)eturn");

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.KeyChar)
                {
                    case 'E':
                    case 'e':
                        this.GoTo(new EditAddressScreen(this.Contactee));
                        break;
                    case 'D':
                    case 'd':
                        Address.CurrentAddress.Contact.Remove(this.Contactee);
                        return;
                    case 'R':
                    case 'r':
                        return;
                }
            }
        }
    }
}


