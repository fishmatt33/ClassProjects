using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Data;

namespace BootcampAdderssBook.Screens
{
    public class SelectAddressScreen : Screen
    {
        public override void Display()
        {
            var Contacts = ContactList.CurrentContactList.Contacts;
            for (int i = 0; i < Contacts.Count; i++)
            {
                var Contact = Contacts[i];
                Console.WriteLine("{0,2}) {1:-30}  {2:-20}", i + 1, Contact.FirstName, Contact.LastName);
            }
            Console.WriteLine();
            while (true)
            {
                Console.Write("Enter Contact # or press Enter to go back: ");
                string input = Console.ReadLine();

                if (String.IsNullOrEmpty(input))
                    return;

                int index;
                if (int.TryParse(input, out index))
                {
                    index--;
                    if (index >= 0 && index < Contacts.Count)
                    {
                        ViewAddressScreen next = new ViewAddressScreen(Contacts[index]);
                        this.GoTo(next);
                        break;
                    }
                }
            }
        }
    }
}