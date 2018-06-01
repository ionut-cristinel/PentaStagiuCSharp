using HomeWork01Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01
{
    class Application
    {
        static void Main(string[] args)
        {
            ShowCommands();
            GetCommand();
        }

        // afiseaza in consola comenzile ce pot fi folosite de user
        private static void ShowCommands()
        {
            Console.WriteLine("\n");
            Console.WriteLine("  You must use the following commands:");
            Console.WriteLine("  +----------------------------+");
            Console.WriteLine("  |   create account           |");
            Console.WriteLine("  |   log in                   |");
            Console.WriteLine("  |   log out                  |");
            Console.WriteLine("  |   create post              |");
            Console.WriteLine("  |   display post             |");
            Console.WriteLine("  |   exit                     |");
            Console.WriteLine("  |   help                     |");
            Console.WriteLine("  +----------------------------+");
            Console.WriteLine("\n");
        }

        // citeste comanda data de user si executa codul aferent ei
        private static void GetCommand()
        {
            string command;
            do
            {
                command = Console.ReadLine().Trim().ToLower();
                switch (command)
                {
                    case "create account":
                        new UserService(command);
                        break;
                    case "log in":
                        new UserService(command);
                        break;
                    case "log out":
                        new UserService(command);
                        break;
                    case "create post":
                        new Board(command);
                        break;
                    case "display post":
                        new Board(command);
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    case "help":
                        ShowCommands();
                        break;
                    default:
                        Console.WriteLine("\n  Please choose a valid option from the menu!");
                        ShowCommands();
                        break;
                }
            }
            while (true);
        }
    }
}
