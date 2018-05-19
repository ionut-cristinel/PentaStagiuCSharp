using System;

namespace Homework01
{
    class Program
    {
        // timpul curent
        private static DateTime currentTime;

        // data neasterii a user-ului
        private static DateTime birthDate;

        // varsta user-ului
        private static int age;

        // genul user-ului
        private static int gender;

        static void Main(string[] args)
        {
            Console.Title = "Do you know when you retire?";

            // label-ul va fi folosit de comanda repeat >
            repeteAll:

            Console.WriteLine("If you want to find the year of retirement, follow these steps:");

            // proprietatile clasei primesc valori
            birthDate = GetBirthDate();
            currentTime = DateTime.Now;
            age = GetAge();
            gender = GetGender();

            // se afiseaza pentru user mesajul cu varsta pensionarii in functie de gen si cat mai are pana atunci
            switch (gender)
            {
                case 0:
                    Console.WriteLine($"\nYou can retire at the age of 63. You have {63 - age} years left until you can retire.");
                    break;
                case 1:
                    Console.WriteLine($"\nYou can retire at the age of 65. You have {65 - age} years left until you can retire.");
                    break;
            }

            // se arata o lista cu comenzi pe care user-ul le poate utiliza pentru alte detalii
            ShowCommans();

            // label folosit pentru o comanda noua data de user
            repeateCommands:

            // set de instructiuni executate in functie de comanda scrisa de user
            switch (Console.ReadLine())
            {
                case "exit >":
                    Environment.Exit(0);
                    break;
                case "help >":
                    ShowCommans();
                    break;
                case "repeat >":
                    Console.Clear();
                    goto repeteAll;
                case "current time >":
                    Console.WriteLine($"current time > {DateTime.Now}\n");
                    break;
                case "my age >":
                    Console.WriteLine($"my age > {age}\n");
                    break;
                case "my birth year >":
                    Console.WriteLine($"my birth year > {birthDate.Year}\n");
                    break;
                case "my birth month >":
                    Console.WriteLine($"my birth month > {birthDate.Month}\n");
                    break;
                case "my birth day >":
                    Console.WriteLine($"my birth day > {birthDate.Day}\n");
                    break;
                default:
                    Console.WriteLine("You entered a invalid command, enter help > for details.\n");
                    break;
            }

            goto repeateCommands;
        }

        // metoda care returneaza DateTime ce reprezinta data de nastere a user-ului
        // daca user-ul introduce o valoare invalida pentru an, luna sau zi va trebui sa repete actiunea
        private static DateTime GetBirthDate()
        {
            Console.WriteLine("\nYear of birth:");
            year:
            int? birthDateYear = null;
            try
            {
                birthDateYear = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You entered invalid value, try again:");
                goto year;
            }

            Console.WriteLine("\nMonth:");
            month:
            int? birthDateMonth = null;
            try
            {
                birthDateMonth = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You entered invalid value, try again:");
                goto month;
            }

            Console.WriteLine("\nDay:");
            day:
            int? birthDateDay = null;
            try
            {
                birthDateDay = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You entered invalid value, try again:");
                goto day;
            }

            return new DateTime(birthDateYear.Value, birthDateMonth.Value, birthDateDay.Value);
        }

        // metoda care returneaza un int ce reprezinta varsta user-ului
        private static int GetAge()
        {
            TimeSpan timePeriod = currentTime - birthDate;
            int years = timePeriod.Days / 365;

            return years;
        }

        // metoda care returneaza un int ce reprezinta genul user-ului
        // daca user-ul introduce o valoare incorecta v-a trebui sa repete actiunea
        private static int GetGender()
        {
            Console.WriteLine("\nPlease add your gender (F / M):");

            selectAgain:

            string userInputGender = Console.ReadLine();
            int? selectGender;
            Genders userGender;

            switch (userInputGender)
            {
                case "F":
                    userGender = Genders.Female;
                    selectGender = (int)userGender;
                    break;
                case "M":
                    userGender = Genders.Male;
                    selectGender = (int)userGender;
                    break;
                default:
                    Console.WriteLine("\nYou have entered a wrong value, you have to choose between F and M");
                    goto selectAgain;
            }

            return selectGender.Value;
        }

        // metoda care afiseaza o lista cu comenzile ce pot fi folosite in cadrul aplicatiei
        private static void ShowCommans()
        {
            Console.WriteLine("\nUse the following commands for more details:\n");
            Console.WriteLine("  +-----------------------------------------------------------------------+");
            Console.WriteLine("  | help >                       |  display all valid orders              |");
            Console.WriteLine("  | repeat >                     |  repeat all the steps                  |");
            Console.WriteLine("  | my age >                     |  display of age                        |");
            Console.WriteLine("  | my birth year >              |  birthday display                      |");
            Console.WriteLine("  | my birth month >             |  displaying the birth moon             |");
            Console.WriteLine("  | my birth day >               |  birthday display                      |");
            Console.WriteLine("  | current time >               |  display current time                  |");
            Console.WriteLine("  | exit >                       |  close the application                 |");
            Console.WriteLine("  +-----------------------------------------------------------------------+\n");
        }
    }
}