using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhone
{
    public class PhoneContacts
    {
        private string _firstName;
        private string _lastName;
        private string _address;
        private string _email;
        private string [] _mobilePhone;
        private string [] _homePhone;

        public void AddFirstName(string name)
        {
            _firstName = name;
        }
        
        public void AddLastName(string name)
        {
            _lastName = name;
        }

        public void AddAddress(string address)
        {
            _address = address;
        }

        public void AddEmail(string email)
        {
            _email = email;
        }

        public void AddMobilePhone(string [] mPhone)
        {
            for (int i = 0; i < 11; i++)
            {
                _mobilePhone [i] = mPhone;
            }
            
        }

    }
}
