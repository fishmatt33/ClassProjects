using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookInClass
{
    public class Contact
    {
        private string _firstName;
        private string _lastName;
        private string _company;

        private List<PhoneNumber> _numbers;
        private List<EmailAddress> _emails;

        private string _ringtone;
        private string _vibration;
        private string _textTone;
        private string _textVibration;

        private string _url;
        private DateTime _birthday;
        private Address _address;
    }
}
