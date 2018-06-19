using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWork01Library
{
    // clasa folosita pentru a valida datele citite de la tastatura
    static class Validate
    {
        // constanta care reprezinta o expresie regulata folosita pentru a valida un email
        private const string EmailPatern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

        // metoda care valideaza un mail
        // returneaza true in caz de succes si false in caz contrar
        public static bool EmailValidate(string email)
        {
            if (Regex.IsMatch(email, EmailPatern))
                return true;
            else
                return false;
        }

        // metoda care valideaza orice valoare citita de la tastatura
        // daca valoarea este goala sau nula returneaza false iar in caz contrar true
        public static bool ValidateString(string text)
        {
            if (!string.IsNullOrEmpty(text.Trim()))
                return true;
            else
                return false;
        }
    }
}
