using System;

namespace GuessTheNumber
{
    class Program
    {
        // proprietate care va tine numarul ce trebuie ghicit
        private static int randomNumber;
        // proprietate care va tine valoarea introdusa de user
        private static int userNumber;

        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Title = "GuessTheNumber";
            Console.Clear();
            Console.WriteLine("Please enter a number between 1 and 100:");

            randomNumber = GetRandomNumber();

            CheckNumber();

            Console.WriteLine("\n Enter play if you want to repeat the game or exit if you want to finish.");

            RepeatOrExit(Console.ReadLine());
        }

        // metoda CheckNumber() care verifica daca numarul introdus de user se potriveste cu cel care trebuie ghicit
        private static void CheckNumber()
        {
            userNumber = GetUserName();
            if (userNumber != randomNumber)
            {
                if (userNumber < randomNumber)
                {
                    Console.WriteLine("Your number is too small, choose again.");
                    CheckNumber();
                }
                else
                {
                    Console.WriteLine("Your number is too big, choose again.");
                    CheckNumber();
                }
            }
            else
            {
                Console.WriteLine("\n Congratulations you got the number.");
                Console.Beep();
            }
        }

        // metoda RepeatOrExit() folosita pentru reluarea jocului sau iesirea din aplicatie
        private static void RepeatOrExit(string message)
        {
            if (message == "play")
            {
                Console.Clear();
                Main();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        // metoda GetRandomNumber folosita pentru a returna un numar aleator
        private static int GetRandomNumber()
        {
            Random number = new Random();
            return number.Next(1, 100);
        }

        // metoda GetUserName() folosita pentru a returna valoarea introdusa de user
        private static int GetUserName()
        {
            string value = Console.ReadLine();
            return int.Parse(value);
        }
    }
}
