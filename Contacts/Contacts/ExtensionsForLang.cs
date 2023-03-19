using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    internal class ExtensionsForLang
    {
        private readonly CultureInfo _enCulture = new ("en-US");
        private readonly CultureInfo _ukCulture = new ("uk-UA");
        public enum Lang
        {
            English,
            Ukrainian,
            Number
        }

        public static Lang DefineLanguage(char letter)
        {
            if (char.IsDigit(letter))
            {
                return Lang.Number;
            }

            if (!char.IsLetter(letter))
            {
                throw new InvalidOperationException();
            }

            if (letter >= 'A' && letter <= 'Z')
            {
                return Lang.English;
            }

            if (letter >= 'А' && letter <= 'Я')
            {
                return Lang.Ukrainian;
            }

            throw new InvalidOperationException($"Does not supported language for letter: {letter}");
        }
    }
}
