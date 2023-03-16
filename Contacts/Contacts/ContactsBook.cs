using static Contacts.ExtensionsForLang;

namespace Contacts
{
    internal class ContactsBook
    {
        private static SortedDictionary<char, List<Contact>> _enContacts;
        private static SortedDictionary<char, List<Contact>> _ukContacts;
        private static SortedDictionary<char, List<Contact>> _numContacts;
        static ContactsBook()
        {
            _enContacts = new ();
            _ukContacts = new ();
            _numContacts = new ();
        }

        public void PrintContactBook(Lang lang)
        {
            switch (lang)
            {
                case Lang.English:
                    foreach (var contacts in _enContacts.Values)
                    {
                        foreach (Contact contact in contacts)
                        {
                            Console.WriteLine(contact.ToString() + Environment.NewLine);
                        }
                    }

                    break;
                case Lang.Ukrainian:
                    foreach (var contacts in _ukContacts.Values)
                    {
                        foreach (Contact contact in contacts)
                        {
                            Console.WriteLine(contact.ToString() + Environment.NewLine);
                        }
                    }

                    break;
                case Lang.Number:
                    foreach (var contacts in _numContacts.Values)
                    {
                        foreach (Contact contact in contacts)
                        {
                            Console.WriteLine(contact.ToString() + Environment.NewLine);
                        }
                    }

                    break;
            }
        }

        public void PrintContactBook()
        {
            foreach (var contacts in _enContacts.Values)
            {
                foreach (Contact contact in contacts)
                {
                    Console.WriteLine(contact.ToString() + Environment.NewLine);
                }
            }

            foreach (var contacts in _ukContacts.Values)
            {
                foreach (Contact contact in contacts)
                {
                    Console.WriteLine(contact.ToString() + Environment.NewLine);
                }
            }

            foreach (var contacts in _numContacts.Values)
            {
                foreach (Contact contact in contacts)
                {
                    Console.WriteLine(contact.ToString() + Environment.NewLine);
                }
            }
        }

        public void Add(Contact contact)
        {
            char firstLetter = contact.FirstName[0];
            try
            {
                switch (DefineLanguage(firstLetter))
                {
                    case Lang.English:
                       if (!_enContacts.ContainsKey(firstLetter))
                       {
                            _enContacts[firstLetter] = new List<Contact>();
                       }

                       _enContacts[firstLetter].Add(contact);
                       break;
                    case Lang.Ukrainian:
                       if (!_ukContacts.ContainsKey(firstLetter))
                       {
                            _ukContacts[firstLetter] = new List<Contact>();
                       }

                       _ukContacts[firstLetter].Add(contact);
                       break;
                    case Lang.Number:
                       if (!_numContacts.ContainsKey(firstLetter))
                       {
                            _numContacts[firstLetter] = new List<Contact>();
                       }

                       _numContacts[firstLetter].Add(contact);
                       break;
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                if (!_enContacts.ContainsKey(firstLetter))
                {
                    _enContacts[firstLetter] = new List<Contact>();
                }

                _enContacts[firstLetter].Add(contact);
            }
        }

        public void SearchContact(char firstLetter)
        {
            firstLetter = char.ToUpper(firstLetter);
            List<Contact> contacts = new ();
            switch (DefineLanguage(firstLetter))
            {
                case Lang.English:
                    if (!_enContacts.ContainsKey(firstLetter))
                    {
                        Console.WriteLine("Contacts don't found!");
                    }
                    else
                    {
                        contacts = _enContacts[firstLetter];
                    }

                    break;
                case Lang.Ukrainian:
                    if (!_ukContacts.ContainsKey(firstLetter))
                    {
                        Console.WriteLine("Contacts don't found!");
                    }
                    else
                    {
                        contacts = _ukContacts[firstLetter];
                    }

                    break;
                case Lang.Number:
                    if (!_numContacts.ContainsKey(firstLetter))
                    {
                        Console.WriteLine("Contacts don't found!");
                    }
                    else
                    {
                        contacts = _numContacts[firstLetter];
                    }

                    break;
            }

            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact.ToString());
            }
        }
    }
}
