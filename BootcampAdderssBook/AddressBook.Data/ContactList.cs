using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Models;

namespace AddressBook.Data

{
    public class ContactList
    {
        public static ContactList CurrentContactList { get; private set; }

        static ContactList()
        {
            CurrentContactList = new ContactList();
        }

        public string AddressName { get; set; }
        public List<AddressValues> Contacts { get; private set; }

        public ContactList()
        {
            Contacts = new List<AddressValues>();
        }

        public void SaveToFile(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename, false))
            {
                sw.WriteLine(this.Contacts);
                foreach (AddressValues person in this.Contacts)
                {
                    sw.WriteLine("{0}|{1}|{2}|{3}|{4}",
                        person.FirstName,
                        person.LastName,
                        person.Address,
                        person.Email,
                        person.PhoneNumber);
                }
            }
        }

        public static void LoadAddress(string filename)
        {
            ContactList loadedContactList = new ContactList();

            if (!File.Exists(filename))
            {
                Console.WriteLine("This is an invalid file name.");
                Console.ReadLine();
                return;
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                loadedContactList.AddressName= sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (String.IsNullOrEmpty(line))
                        continue;

                    string[] parts = line.Split('|');

                    AddressValues person = new AddressValues();
                    person.FirstName = parts[0];
                    person.LastName = parts[1];
                    person.Address = parts[2];
                    person.Email = parts[3];
                    person.PhoneNumber = parts[4];

                    loadedContactList.Contacts.Add(person);
                }
            }

            CurrentContactList = loadedContactList;
        }
    }
}

