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
            string[] comands;

            /*
                sunt create obiectele care vor fi utilizate in aplicatie
                obiectele sunt create cu clasa statica Factory
            */

            //  clasa StandardMessage este utilizata pentru a afisa o serie de mesaje utilizatorului
            Message messages =  Factory.CreateStandardMessage();

            //  clasa Brain este responsabila cu procesarea comenzilor adaugate de utilizator si executarea codului aferent fiecarei comanzi
            Brain executeCommands = Factory.CreateBrain();

            //  clasa FileService este responsabila cu executarea operatiilor ce pot fi facute cu fisiere si textul din ele
            File fileService = Factory.CreateFileService(messages);

            messages.WelcomeMessage();
            Commands();
            
            executeCommands.LoadList += fileService.LoadListFromFile;
            executeCommands.SaveList += fileService.SaveToFile;
            executeCommands.AddName += fileService.AddNewName;
            executeCommands.RemoveName += fileService.RemoveName;
            executeCommands.DisplayNames += fileService.DisplayNames;
            executeCommands.FakeCommand += messages.FakeCommandMessage;
            executeCommands.EmptyName += messages.EmptyNameMessage;

            while (true)
            {
                Console.Write("  > ");

                //  este citita comanda de la tastatura si validata cu metoda ValidateUserCommand a clasei Validate
                comands = Validate.ValidateUserCommand(Console.ReadLine());

                //  comanda este trimisa ca parametru metodei ExecuteCommand a clasei Brain
                executeCommands.ExecuteCommand(comands);
            }
        }

        static void Commands()
        {
            Console.WriteLine("\n  Look what you can do in the app:");
            Console.WriteLine("  ---------------------------------------------------------------------------------");
            Console.WriteLine("  load 'file'          load a list of names from a file");
            Console.WriteLine("  add 'name'           add a name to list");
            Console.WriteLine("  remove 'name'        remove a name from list");
            Console.WriteLine("  save 'file'          save the list to a new file");
            Console.WriteLine("  display              display all name from the file that was loaded");
            Console.WriteLine("  ---------------------------------------------------------------------------------");
            Console.WriteLine("  The name of the files or people should not be written between the characters ' '.");
            Console.WriteLine("\n");
        }
    }
}
