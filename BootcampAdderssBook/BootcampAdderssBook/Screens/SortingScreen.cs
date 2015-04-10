using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Data;
using AddressBook.Models;

namespace BootcampAdderssBook.Screens
{
    //internal class SortingScreen : Screen
    //{
    //    public override void Display()
    //    {

    //        var sortedNames =
    //            from n in ContactList.CurrentContactList.Contacts
    //            orderby n.FirstName
    //            select n;

    //        Console.WriteLine("The sorted list of names:");
    //        foreach (var name in sortedNames)
    //        {
    //            Console.WriteLine(name.FirstName);
    //        }
    //        Console.ReadLine();

    //    }
    //}

    internal class SortingScreen : Screen
    {
        public AddressValues Contactee { get; private set; }

        private string GetSortField(SortTypes sortType, AddressValues contact)
        {
            if (sortType == SortTypes.FirstName)
            {
                return contact.FirstName;
            }
            if (sortType == SortTypes.LastName)
            {
                return contact.LastName;
            }
            if (sortType == SortTypes.PhoneNumber)
            {
                return contact.PhoneNumber;
            }
            return contact.FirstName;
        }

        public override void Display()
        {
            Console.WriteLine
                ("Please enter your sorting choice:\n(F)irst Name, (L)ast Name, or (P)hone Number");
            
                ConsoleKeyInfo key = Console.ReadKey(true);

            var sortType = SortTypes.FirstName;
                switch (key.KeyChar)
                {
                    case 'F':
                    case 'f':
                        sortType = SortTypes.FirstName;
                        break;
                    case 'L':
                    case 'l':
                        sortType = SortTypes.LastName;
                        break;
                    case 'P':
                    case 'p':
                        sortType = SortTypes.PhoneNumber;
                        break;
                }
            
            var sortedNames =
                from n in ContactList.CurrentContactList.Contacts
                orderby GetSortField(sortType, n)
                select n;

            Console.WriteLine("The sorted list of names:");
            foreach (var name in sortedNames)
            {
                Console.WriteLine("{0,-10}{1,0}{2,20}",name.FirstName,name.LastName,name.PhoneNumber);
            }
            Console.ReadLine();


        }
    }
    
}
