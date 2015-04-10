using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Data;

namespace BootcampAdderssBook.Screens
{
    public class SaveAddressScreen : Screen
    {
        public override void Display()
        {
            Console.WriteLine("Enter file to save: ");

            string filename = Console.ReadLine();

            Address.CurrentAddress.SaveToFile(filename);

            Console.WriteLine("Contact saved! Press Enter to continue...");
            Console.ReadLine();
        }
    }
}

