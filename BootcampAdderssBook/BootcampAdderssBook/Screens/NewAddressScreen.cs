using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Data;
using AddressBook.Models;

namespace BootcampAdderssBook.Screens
{
    public class NewAddressScreen : Screen
    {
        public override void Display()
        {
            AddressValues b = new AddressValues();

			Console.WriteLine("Enter address details...");
			Console.WriteLine();
			
			Console.Write("First Name: ");
			b.FirstName = Console.ReadLine();

			Console.Write("Last Name: ");
			b.LastName = Console.ReadLine();

            Console.Write("Address: ");
            b.Address = Console.ReadLine();

		    Console.Write("E-mail: ");
			b.Email =(Console.ReadLine());

			Console.Write("Phone Number: ");
			b.PhoneNumber =(Console.ReadLine());

			AddressBook.Data.ContactList.CurrentContactList.Contacts.Add(b);
		}
    }
}
