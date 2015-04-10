using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Models;

namespace BootcampAdderssBook.Screens
{
    public class EditAddressScreen : Screen
    {
        public AddressValues Address { get; private set; }

        public EditAddressScreen(AddressValues address)
        {
            this.Address = address;
        }

        public override void Display()
        {
            Console.WriteLine("Edit contact details. Use Enter to accept current value, or 'NONE' to clear it out.");
            Console.WriteLine();

            this.Address.FirstName = Edit("First Name", this.Address.FirstName);
            this.Address.LastName = Edit("Last Name: ", this.Address.LastName);
            this.Address.Address = Edit("Address: ", this.Address.Address);
            Address.Email = (Edit("E-mail address: ", Address.Email));
            Address.PhoneNumber = (Edit("Phone Number: ", Address.PhoneNumber));
        }

        private string Edit(string prompt, string initialValue)
        {
            Console.Write("{0} ({1}): ", prompt, initialValue);
            string input = Console.ReadLine();

            if (String.IsNullOrEmpty(input))
                return initialValue;

            if (input == "NONE")
                return String.Empty;

            return input;
        }
    }
}
