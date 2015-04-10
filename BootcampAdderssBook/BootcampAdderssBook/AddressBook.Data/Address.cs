using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Models;

namespace AddressBook.Data

{
    public class Address
    {
        public static Address CurrentAddress { get; private set; }

        static Address()
        {
            CurrentAddress = new Address();
        }

        public string AddressName { get; set; }
        public List<AddressValues> Contact { get; private set; }

        public Address()
        {
            Contact = new List<AddressValues>();
        }

        public void SaveToFile(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename, false))
            {
                sw.WriteLine(this.Contact);
                foreach (AddressValues person in this.Contact)
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
            Address loadedAddress = new Address();

            using (StreamReader sr = new StreamReader(filename))
            {
                loadedAddress.AddressName= sr.ReadLine();

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

                    loadedAddress.Contact.Add(person);
                }
            }

            CurrentAddress = loadedAddress;
        }
    }
}

