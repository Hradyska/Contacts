using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace Contacts
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ContactsBook book = new ContactsBook();
            book.Add(new Contact() { FirstName = "Jon", LastName = "smith", PhoneNumber = "000-000", EMail = "aaa@gmail.com" });
            book.Add(new Contact() { FirstName = "Samanta", LastName = "Carter", PhoneNumber = "0123-000", EMail = "sss@gmail.com" });
            book.Add(new Contact() { FirstName = "Андрій", LastName = "Петренко", PhoneNumber = "0123-000", EMail = "ddd@gmail.com" });
            book.Add(new Contact() { FirstName = "0Андрій", LastName = "Петренко", PhoneNumber = "0123-000", EMail = "hhh@gmail.com" });
            book.Add(new Contact() { FirstName = "Аліна", LastName = "Петренко", PhoneNumber = "0123-000", EMail = "fff@gmail.com" });
            book.Add(new Contact() { FirstName = "Andy", PhoneNumber = "0123-000", EMail = "sss@gmail.com" });
            book.Add(new Contact() { FirstName = "Тарас", LastName = "Шевченко", PhoneNumber = "0123-000", EMail = "sss@gmail.com" });
            book.Add(new Contact() { FirstName = "Amanda", PhoneNumber = "0123-000", EMail = "lll@gmail.com" });
            book.Add(new Contact() { FirstName = "_Amanda", PhoneNumber = "0123-000", EMail = "kkk@gmail.com" });
            book.Add(new Contact() { FirstName = "1Amanda", PhoneNumber = "0123-000" });
            book.Add(new Contact() { FirstName = "3Amanda", PhoneNumber = "0123-000" });
            book.Add(new Contact() { FirstName = "9Amanda", PhoneNumber = "0123-000" });
            book.PrintContactBook();
            Console.WriteLine("**************************");
            book.PrintContactBook(ExtensionsForLang.Lang.Ukrainian);
            Console.WriteLine();
            Console.WriteLine("**************************");
            book.SearchContact('А');
            book.SearchContact('a');
            book.SearchContact('j');
        }
    }
}