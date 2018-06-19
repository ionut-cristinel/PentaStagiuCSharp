using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01Library
{
    // clasa CommandLine este responsabila de afisarea in consola a comenzilor care pot fi folosite in cadrul aplicatiei
    public static class CommandLine
    {
        public static void UserCommandLine()
        {
            Console.WriteLine("\n");
            Console.WriteLine("  ca             create an account");
            Console.WriteLine("  lg in          log in");
            Console.WriteLine("  lg out         log out");
            Console.WriteLine("  add p          add a post");
            Console.WriteLine("  show all       show all posts");
            Console.WriteLine("  show p id      show a post by id");
            Console.WriteLine("  help           show the command list");
            Console.WriteLine("  exit           close the application");
            Console.WriteLine("\n");
        }
    }
}
