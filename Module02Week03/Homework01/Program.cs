using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework01Library;

namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            UserCommands();

            while (true)
            {
                Console.Write("  ");
                switch (Console.ReadLine().Trim())
                {
                    case "by age":
                        DisplayUserByInterval();
                        break;
                    case "by name":
                        DisplayUserByName();
                        break;
                    case "clear":
                        Console.Clear();
                        UserCommands();
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("  You entered a wrong order!");
                        break;
                }
            }
        }

        public static void DisplayUserByInterval()
        {
            var persons = JsonHelper.GetDataFromJson();

            var start = new DateTime(1985, 1, 1, 0, 0, 0);
            var end = new DateTime(1995, 12, 31, 23, 59, 59);

            var results = persons
                .Where(person => person.BirthDate > start)
                .Where(person => person.BirthDate < end)
                .Select(person => $"{person.FirstName} {person.LastName}")
                .ToDictionary(person => person, person => person.Count(c => "aeiou".Contains(Char.ToLower(c))))
                .OrderBy(person => person.Value)
                .Select(person => person.Key)
                .ToList();

            foreach (var name in results)
            {
                Console.WriteLine($"  {name}");
            }

            Console.WriteLine($"\n  {results.Count} results returned.");
        }

        public static void DisplayUserByName()
        {
            var persons = JsonHelper.GetDataFromJson();

            var results = persons
                .Select(p => new User()
                {
                    Username = $"{p.FirstName}{p.LastName}{p.BirthDate.ToString("yy")}",
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    Gender = p.Gender,
                    BirthDate = p.BirthDate
                })
                .ToList();

            foreach (User user in results)
            {
                Console.WriteLine($"  {user}");
            }

            Console.WriteLine($"\n  {results.Count} results returned.");
        }

        public static void UserCommands()
        {
            Console.WriteLine("\n  Welcome to my app!");
            Console.WriteLine("\n  You can use the following commands:");
            Console.WriteLine("  -------------------------------------------------------------------------");
            Console.WriteLine("   by age         Display all people born in the 85-95 range.");
            Console.WriteLine("   by name        Displays the list created with the 'create list' command.");
            Console.WriteLine("   clear          Empty console content.");
            Console.WriteLine("   exit           Close the application.");
            Console.WriteLine("  ------------------------------------------------------------------------- \n");
        }
    }
}
