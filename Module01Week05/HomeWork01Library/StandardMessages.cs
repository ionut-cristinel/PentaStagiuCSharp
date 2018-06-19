using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01Library
{
    // clasa statica StandardMessages folosita pentru a afisa in consola diferite mesaje de informare pentru user
    public static class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("\n  Welcom to my application!");
        }

        public static void FakeCommand()
        {
            Console.WriteLine("  > This command does not exist! \n    Try 'help' to see all the commands.");
        }

        public static void FirstName()
        {
            Console.Write("  > Enter the first name: ");
        }

        public static void LastName()
        {
            Console.Write("  > Enter the last name: ");
        }

        public static void Email()
        {
            Console.Write("  > Enter the email: ");
        }

        public static void Password()
        {
            Console.Write("  > Enter the password: ");
        }

        public static void BirthDate()
        {
            Console.Write("  > Enter birth date (yyyy, mm, dd): ");
        }

        public static void FakeValue(string user = null)
        {
            if(user != null)
                Console.Write($"  > ({user}): Wrong value, try again: ");
            else
                Console.Write("  > Wrong value, try again: ");
        }

        public static void FakeEmail()
        {
            Console.Write("  > Email invalid, try again: ");
        }

        public static void FakeBirthDate()
        {
            Console.Write("  > Invalid birth date format: ");
        }

        public static void ErrorLogIn()
        {
            Console.WriteLine("  > Sorry, your password or email does not match, try again.");
        }

        public static void SuccessLogIn(string user)
        {
            Console.WriteLine($"  > ({user}): You are now connected, you can add or read posts.");
        }

        public static void UserDeconnected()
        {
            Console.WriteLine("  > You were disconnected.");
        }

        public static void UserNotConnected()
        {
            Console.WriteLine("  > You are not connected.");
        }

        internal static void AddPost(string user)
        {
            Console.Write($"  > ({user}): Add your post here: ");
        }

        public static void NewPost(string user)
        {
            Console.WriteLine($"  > ({user}): A new post has been added!");
        }

        public static void WrongId(string user)
        {
            Console.WriteLine($"  > ({user}): Post Id is wrong!");
        }

        public static void NullIdPost(string user)
        {
            Console.WriteLine($"  > ({user}): There is no post with this id!");
        }
    }
}
