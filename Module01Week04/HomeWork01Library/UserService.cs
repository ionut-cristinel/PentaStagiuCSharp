using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01Library
{
    // clasa responsabila de:
        //  crearea contului de utilizator
        //  conectarea utilizatorului
        //  deconectarea utilizatorului
    public class UserService
    {
        //  lista in care vor fi adaugati user-ii aplicatiei
        private static List<User> Users = new List<User>();
        //  lista in care vor fi retinute valorile adaugate de user pentru creare cont
        private List<string> UserInput { get; set; }
        // id-ul utilizatorului
        private int NextId = 1;

        // constructor gol
        public UserService()
        {

        }

        // constructor care executa comanda introdusa de user
        public UserService(string command)
        {
            switch (command)
            {
                case "create account":
                    CreateAccount();
                    break;
                case "log in":
                    LogIn();
                    break;
                case "log out":
                    LogOut();
                    break;
            }
        }

        // metoda folosita pentru creare cont
        private void CreateAccount()
        {
            // se citesc pe rand valorile adaugate de user
            // valorile sunt validate de metoda ValidareUserInput() si adaugate in lista UserInput
            UserInput = new List<string>();
            Console.WriteLine("\n  Enter your First Name:");
            UserInput.Add(this.ValidateUserInput());
            Console.WriteLine("\n  Enter your Last Name:");
            UserInput.Add(this.ValidateUserInput());
            Console.WriteLine("\n  Enter your Email:");
            UserInput.Add(this.ValidateUserInput());
            Console.WriteLine("\n  Enter your Password:");
            UserInput.Add(this.ValidateUserInput());
            Console.WriteLine("\n  Enter your Birth Date (yyyy, mm, dd):");
            
            // este apelate metoda AddUser() pentru a crea noul user
            AddUser(this.UserBirthDate(), false, this.UserInput[0], this.UserInput[1], this.UserInput[2], this.UserInput[3]);
            Console.WriteLine("  Your account has been successfully created.");
            Console.WriteLine("  To create a post you must log in.\n");
        }

        // metoda folosita pentru adaugarea unui user nou
        private User AddUser(DateTime birthDate, bool isLogin, params string[] args)
        {
            User user = new User(NextId++, birthDate, isLogin,  args);
            Users.Add(user);
            return user;
        }

        // metoda folosita pentru logarea user-ului in aplicatie
        private void LogIn()
        {
            // se citesc pe rand valorile adaugate de user
            // valorile sunt validate de metoda ValidareUserInput()
            Console.WriteLine("\n  Enter your First Name:");
            string firstName = this.ValidateUserInput();
            Console.WriteLine("\n  Enter your Password:");
            string password = this.ValidateUserInput();

            // daca lista cu useri este goala persoana trebuie sa-si creeze cont inainte de a se loga
            if (Users.Count == 0)
            {
                Console.WriteLine("  You need to create an account.\n");
                return;
            }

            // se parcurge lista cu useri
            foreach (User user in Users)
            {
                // daca se gaseste in lista o potrivire pentru valorile adaugate de user atunci este conectat
                if (user.FirstName == firstName && user.Password == password)
                {
                    user.IsLogIn = true;
                    Console.WriteLine("  You are logged in, you can now add posts.\n");
                    return;
                }
                Console.WriteLine("  Your name or password is incorrect, try again.\n");
            }
        }

        // metoda folosita pentru deconectarea utilizatorului
        private void LogOut()
        {
            foreach (User user in Users)
            {
                if (user.IsLogIn)
                {
                    user.IsLogIn = false;
                    Console.WriteLine("  You're disconnected.\n");
                    return;
                }
            }
            Console.WriteLine("  You are not connected.\n");
        }

        // metoda care returneaza din lista de useri pe cel conectat
        // metoda folosita pentru a obtine autorul unui post nou
        public string GetLoggedUser()
        {
            foreach (User user in Users)
            {
                if (user.IsLogIn)
                {
                    return user.FirstName;
                }
            }
            return bool.FalseString;
        }

        // metoda folosita pentru validarea informatiilor introduse de user
        // metoda returneaza un string
        private string ValidateUserInput()
        {
            while (true)
            {
                string userValue = Console.ReadLine();

                if (string.IsNullOrEmpty(userValue.Trim()))
                {
                    Console.WriteLine("\n  You must add a valid value:");
                    this.ValidateUserInput();
                }
                return userValue;
            }
        }

        // metoda care returneaza data nasteri pe baza valorii introduse de user
        private DateTime UserBirthDate()
        {
            UserInput.Add(this.ValidateUserInput());
            repeat:
            string[] userBirthDate = UserInput[4].Split(',');
            int[] birtDate = new int[3];

            try
            {
                birtDate[0] = int.Parse(userBirthDate[0]);
                birtDate[1] = int.Parse(userBirthDate[1]);
                birtDate[2] = int.Parse(userBirthDate[2]);

                return new DateTime(birtDate[0], birtDate[1], birtDate[2]);
            }
            catch
            {
                Console.WriteLine("\n  You must add a valid value:");
                UserInput[4] = this.ValidateUserInput();
                goto repeat;
            }
        }
    }
}
