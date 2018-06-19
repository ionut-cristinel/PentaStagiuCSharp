using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01Library
{
    // clasa partiala folosita pentru a defini actiunile care pot fi facute de un user
    // clasa deriva din clasa abstracta Service
    public partial class UserService : Service
    {
        // metoda returneaza un string citit de la tastatura, dupa ce a fost validat
        private string GetUserValue(string text, string user = null)
        {
            if (Validate.ValidateString(text))
            {
                return text.Trim();
            }
            else
            {
                StandardMessages.FakeValue(user);
                GetUserValue(UserCommand.Read());
                return bool.FalseString;
            }
        }

        // metoda care returneaza un mail citit de la tastatura, dupa ce este validat
        private string GetUserEmail(string text)
        {
            if (Validate.EmailValidate(text))
            {
                return text.Trim();
            }
            else
            {
                StandardMessages.FakeEmail();
                GetUserEmail(UserCommand.Read());
                return bool.FalseString;
            }
        }

        // metoda care transforma un string in data si timp
        // DateTime-ul returnat reprezinta data nasteri a userilor
        private DateTime GetUserBirthDate(string text)
        {
            if (Validate.ValidateString(text))
            {
                try
                {
                    string[] birthDateValues = text.Split(',');
                    int year = int.Parse(birthDateValues[0]);
                    int month = int.Parse(birthDateValues[1]);
                    int day = int.Parse(birthDateValues[2]);

                    return new DateTime(year, month, day);
                }
                catch
                {
                    StandardMessages.FakeBirthDate();
                    GetUserBirthDate(UserCommand.Read());
                    return DateTime.Now;
                }
            }
            else
            {
                StandardMessages.FakeBirthDate();
                GetUserBirthDate(UserCommand.Read());
                return DateTime.Now;
            }
        }

        private void OnUserNotConnected()
        {
            if (UserNotConnected != null)
                UserNotConnected();
        }

        private void OnNewMessage(string user)
        {
            if (NewMessage != null)
                NewMessage(user);
        }

        private void OnNewPostIsAdded(short id, Post post)
        {
            if (NewPostIsAdded != null)
                NewPostIsAdded(id, post);
        }
    }
}
