using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01Library
{
    //  clasa responsabila de afisarea unor mesaje de informare sau eroare
    //  implementeaza metodele clasei abstracte Message
    public class StandardMessage : Message
    {
        public override void WelcomeMessage()
        {
            Console.WriteLine("\n  Welcome to my aplication!");
        }

        public override void MissingFileMessage()
        {
            Console.WriteLine("  > This file does not exist!");
            Console.WriteLine("    You can use the predefined People.txt file or another created by you.");
        }

        public override void FakeCommandMessage(object sender, EventArgs e)
        {
            Console.WriteLine("  > This command does not exist, try again.");
        }

        public override void EmptyNameMessage(object sender, EventArgs e)
        {
            Console.WriteLine("  > This command requires a second parameter, the name of a person or file.");
        }

        public override void DisplayBeforeLoaded()
        {
            Console.WriteLine("  > You have nothing to show.");
            Console.WriteLine("    First you have to load a file using the 'load' command.");
        }

        public override void InvalidFileNameMessage()
        {
            Console.WriteLine("  > The file name is not correct, the .txt extension is required.");
        }

        public override void SuccessMessage()
        {
            Console.WriteLine("  > The operation was successful.");
        }

        public override void SaveBeforeLoaded()
        {
            Console.WriteLine("  > You have nothing to save.");
            Console.WriteLine("    First you have to load a file using the 'load' command.");
        }

        public override void RemoveBeforeLoaded()
        {
            Console.WriteLine("  > You have nothing to remove.");
            Console.WriteLine("    First you have to load a file using the 'load' command.");
        }

        public override void NameNotFound()
        {
            Console.WriteLine("  > The name not found.");
        }

        public override void NameHasBeenDeleted()
        {
            Console.WriteLine("  > The name has been deleted.");
        }

        public override void InvalidPersonName()
        {
            Console.WriteLine("  > This name is invalid, a name must contain only letters and space.");
        }
    }
}
