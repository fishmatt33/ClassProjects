using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Data;

namespace BootcampAdderssBook.Screens
{
    public class SetAddressNameScreen : Screen 
    {
        public override void Display()
        {
            Console.WriteLine("Enter new contact name: ");

            AddressBook.Data.ContactList.CurrentContactList.AddressName = Console.ReadLine();
        }
    }
}

