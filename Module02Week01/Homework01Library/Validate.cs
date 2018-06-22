using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01Library
{
    //  clasa statica utilizata pentru a valida valorile citite de la tastatura sau luate din fisiere
    public static class Validate
    {
        public static string[] ValidateUserCommand(string command)
        {
            string[] commands = command.Split(' ');
            return commands;
        }

        // verifica daca numele unei persoane este unul valid
        // returneaza true daca numele este valid si false in caz contrar
        internal static bool IsValidName(char[] characters)
        {
            foreach (char character in characters)
            {
                if (Char.IsLetter(character) || character == ' ')
                    continue;
                else
                    return false;
            }
            return true;
        }
    }
}
