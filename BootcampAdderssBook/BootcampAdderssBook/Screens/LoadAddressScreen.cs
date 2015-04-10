using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Data;

namespace BootcampAdderssBook.Screens
{
    public class LoadAddressScreen : Screen
    {
        public override void Display()
        {
           
                Console.WriteLine("Enter file to load: ");

                string filename = Console.ReadLine();

                AddressBook.Data.ContactList.LoadAddress(filename);

        }
    }
}
