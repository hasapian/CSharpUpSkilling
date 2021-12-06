using System;
using System.Collections.Generic;
using System.Text;

namespace MyPhoneBook
{
    public class PhoneBookEntry
    {
        public string Name { get; }
        public string PhoneNumber { get; }

        public PhoneBookEntry(string name, string phoneNo)
        {
            Name = name;
            PhoneNumber = phoneNo;
        }
    }
}
