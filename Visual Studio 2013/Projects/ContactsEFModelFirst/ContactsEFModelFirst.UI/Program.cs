using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsEFModelFirst.UI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DisplayContacts();
            Console.ReadLine();
        }

        private static void LoadSampleData()
        {
            using (var context = new ContactsContext())
            {
                if (context.People.Count() == 0)
                {
                    var person = new People
                    {
                        FirstName = "Robert",
                        MiddleName = "Allen",
                        LastName = "Doe",
                        PhoneNumber = "867-5309"
                    };
                    context.People.Add(person);

                    person = new People
                    {
                        FirstName = "John",
                        MiddleName = "K",
                        LastName = "Smith",
                        PhoneNumber = "824-3031"
                    };
                    context.People.Add(person);

                    person = new People
                    {
                        FirstName = "Billy",
                        MiddleName = "Albert",
                        LastName = "Minor",
                        PhoneNumber = "907-2212"
                    };
                    context.People.Add(person);

                    person = new People
                    {
                        FirstName = "Kathy",
                        MiddleName = "Anne",
                        LastName = "Ryan",
                        PhoneNumber = "722-0038"
                    };
                    context.People.Add(person);

                    context.SaveChanges();
                }
            }
        }

        private static void DisplayContacts()
        {
            using (var context = new ContactsContext())
            {
                foreach (var person in context.People)
                {
                    Console.WriteLine("{0} {1} {2}, Phone: {3}", person.FirstName, person.MiddleName, person.LastName, person.PhoneNumber);
                }
            }
        }
}
}
