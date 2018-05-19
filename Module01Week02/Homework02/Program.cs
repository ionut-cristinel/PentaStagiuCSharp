using System;
using System.Text;

namespace Homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Get information about a string";
            Console.WriteLine("Introduce-ti orice text:\n");

            repeat:
            string text = Console.ReadLine();
            text = text.Trim();

            // set de instructiuni executate daca textul introdus nu este gol sau null
            if (!string.IsNullOrEmpty(text))
            {
                string showCommands = Showcommands();

                Console.WriteLine($"\nText > {text}");
                Console.WriteLine(showCommands);

                anotherCommand:

                string command = Console.ReadLine();

                // se instantiaza clasa ExecuteCommand pentru a genera raspunsul la comanda user-ului
                new ExecuteCommand(text, command, showCommands);

                goto anotherCommand;
            }
            else
            {
                Console.WriteLine("Nu ai introdus nimic, mai incearca o data:\nTry again:");
                goto repeat;
            }
        }

        // metoda returneaza un string ce contine numarul si detalii despre comenzile ce pot fi folosite de user
        private static string Showcommands()
        {
            string[] commands = new string[12];
            commands[0] = "\nFoloseste urmatoarele comenzi pentru:\n";
            commands[1] = "  +-------------------------------------------------------------------------------------------------+\n";
            commands[2] = "  | help >                           |  pentru afisarea tuturor comenzilor valide                   |\n";
            commands[3] = "  | text >                           |  pentru a afisa textul scris de user                         |\n";
            commands[4] = "  | upper >                          |  pentru a converti tot stringul la caractere mari            |\n";
            commands[5] = "  | lower >                          |  pentru a converti tot stringul la caractere mici            |\n";
            commands[6] = "  | length >                         |  pentru a afla numarul de caractere din string               |\n";
            commands[7] = "  | index of > substring             |  pentru a obtine pozitia unui substring in string            |\n";
            commands[8] = "  | replace > stringVechi, stringNou |  pentru a inlocui un substring din text cu un alt substring  |\n";
            commands[9] = "  | exit >                           |  pentru a inchide consola                                    |\n";
            commands[10] = "  +-------------------------------------------------------------------------------------------------+\n";

            StringBuilder finalCommand = new StringBuilder();

            foreach (string value in commands)
            {
                finalCommand.Append(value);
            }
            return finalCommand.ToString();
        }
    }
}