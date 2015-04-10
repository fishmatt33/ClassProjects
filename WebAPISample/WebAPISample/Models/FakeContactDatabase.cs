using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc.Html;


namespace MyContacts.UI.Models
{
    public class FakeContactDatabase
    {
        static FakeContactDatabase()
        {
            _contacts.AddRange(new[]
            {
                new Contact() { ContactId = 1, Name= "Zeus", PhoneNumber = "867-5309"},
                new Contact() { ContactId = 2, Name= "Apollo", PhoneNumber = "555-1212"},
                new Contact() { ContactId = 3, Name= "Athena", PhoneNumber = "555-1213"}
            });
        }
        
        private static List<Contact> _contacts = new List<Contact>();

        public List<Contact> GetAll()
        {
            return _contacts;
        }

        public void Add(Contact contact)
        {
            if (_contacts.Any())
                contact.ContactId = _contacts.Max(c => c.ContactId) + 1;
            else
                contact.ContactId = 1;

            _contacts.Add(contact);
        }

        public void Delete(int id)
        {
            _contacts.RemoveAll(c => c.ContactId == id);
        }

        public void Edit(Contact contact)
        {
            Delete(contact.ContactId);
            _contacts.Add(contact);
        }


        public Contact GetById(int id)
        {
            return _contacts.FirstOrDefault(c => c.ContactId == id);
        }
    }
}