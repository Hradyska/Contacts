using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    internal class Contact
    {
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private string _email = string.Empty;
        private string _phoneNumber = string.Empty;
        public Contact()
        {
        }

        public Contact(string firstName)
            : this(firstName, string.Empty, string.Empty, string.Empty)
        {
        }

        public Contact(string firstName, string lastName)
            : this(firstName, lastName, string.Empty, string.Empty)
        {
        }

        public Contact(string firstName, string lastName, string phoneNumber)
           : this(firstName, lastName, string.Empty, phoneNumber)
        {
        }

        public Contact(string firstName, string lastName, string eMail, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            EMail = eMail;
            PhoneNumber = phoneNumber;
        }

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (value == string.Empty)
                {
                }
                else if (value.Length == 1)
                {
                    _firstName = char.ToUpper(value[0]).ToString();
                }
                else
                {
                    _firstName = char.ToUpper(value[0]).ToString() + value.Substring(1);
                }
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (value == string.Empty)
                {
                }
                else if (value.Length == 1)
                {
                    _lastName = char.ToUpper(value[0]).ToString();
                }
                else
                {
                    _lastName = char.ToUpper(value[0]).ToString() + value.Substring(1);
                }
            }
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set => _phoneNumber = value;
        }

        public string EMail
        {
            get
            {
                return _email;
            }
            set
            {
                try
                {
                    SetEMail(value);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    _email = string.Empty;
                }
            }
        }

        public override string ToString()
        {
            return _firstName + " " + _lastName + Environment.NewLine + "PhoneNumber: " + _phoneNumber + Environment.NewLine + "e-mai: " + _email;
        }

        private void SetEMail(string value)
        {
            if (!value.Contains("@"))
            {
                throw new Exception("Incorrect e-mail.");
            }
            else
            {
                _email = value;
            }
        }
    }
}
