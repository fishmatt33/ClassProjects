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
            string displayName = ContactList.CurrentContactList.AddressName != null
                ? ContactList.CurrentContactList.AddressName
                : "Untitled Address";
            Console.WriteLine("{0} ({1} Address)", displayName, ContactList.CurrentContactList.Contacts.Count);
            Console.WriteLine();
        }

        public void GoTo(Screen nextScreen)
        {
            nextScreen.Run();
            this.Run();
        }
    }
}
