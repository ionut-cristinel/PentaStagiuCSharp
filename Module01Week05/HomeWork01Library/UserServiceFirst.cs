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
        public delegate void UserNotConnectedDelegate();
        public event UserNotConnectedDelegate UserNotConnected;

        public delegate void NewMessageDelegate(string user);
        public event NewMessageDelegate NewMessage;

        public delegate void NewPostIsAddedDelegate(short id, Post post);
        public event NewPostIsAddedDelegate NewPostIsAdded;

        // lista in care sunt adaugati toti userii aplicatiei
        private List<User> AllUsers = new List<User>();
        public static MessageBoard AddNewPost = Factory.CreateMessageBoard();
        private int userId = 1;
        private short postId = 0;
        public static string UserConnected = null;

        // metoda utilizata pentru crearea unui cont de utilizator
        public override void CreateAccount()
        {
            // se citesc de la tastatura valori pentru fiecare proprietate din User si se valideaza
            StandardMessages.FirstName();
            string firstName = GetUserValue(UserCommand.Read());
            StandardMessages.LastName();
            string lastName = GetUserValue(UserCommand.Read());
            StandardMessages.Email();
            string email = GetUserEmail(UserCommand.Read());
            StandardMessages.Password();
            string password = GetUserValue(UserCommand.Read());
            StandardMessages.BirthDate();
            DateTime birthDate = GetUserBirthDate(UserCommand.Read());

            // este adaugat un user nou in lista AllUsers
            AllUsers.Add(Factory.CreateUser(userId++, birthDate, firstName, lastName, email, password));
        }

        // metoda folosita pentru conectarea in aplicatie
        public override void LogIn()
        {
            // se citesc de la tastatura emailul si parola
            StandardMessages.Email();
            string email = GetUserEmail(UserCommand.Read());
            StandardMessages.Password();
            string password = GetUserValue(UserCommand.Read());
            bool successConnected = false;

            // se parcurge lista cu useri AllUsers
            // daca este gasit un user cu emailul si parola identice cu cele citite de la tastatura
            // proprietatea IsLogin a userului primeste valoarea true
            foreach (var user in AllUsers)
            {
                if (user.Email == email && user.Password == password)
                {
                    user.IsLogin = true;
                    successConnected = true;
                    UserConnected = user.FirstName;
                }
                if (user.Email != email && user.Password != password && user.IsLogin)
                    user.IsLogin = false;
            }
            if(successConnected)
                StandardMessages.SuccessLogIn(UserConnected);
            else
                StandardMessages.ErrorLogIn();
        }

        // metoda folosita pentru deconectarea unui user
        public override void LogOut()
        {
            bool successDeconnected = false;
            foreach (var user in AllUsers)
            {
                if (user.IsLogin)
                {
                    user.IsLogin = false;
                    successDeconnected = true;
                    UserConnected = null;
                }
            }
            if (successDeconnected)
                StandardMessages.UserDeconnected();
            else
                StandardMessages.UserNotConnected();
        }

        // metoda folosita pentru adaugarea unei postari noi
        // o postare noua poate fi adaugata doar daca userul este conectat
        public override void AddPost()
        {
            if (UserConnected == null)
            {
                OnUserNotConnected();
                return;
            }
            StandardMessages.AddPost(UserConnected);
            string post = GetUserValue(UserCommand.Read(), UserConnected);
            NewPostIsAdded(postId, Factory.CreatePost(postId++, UserConnected, post));
            OnNewMessage(UserConnected);
        }
    }
}
