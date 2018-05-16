using System;

namespace Homework02
{
    class ExecuteCommand
    {
        // reprezinta comanda primita de la user
        private string command;

        // reprezinta un substring din textul user-ului
        private string subString;

        // reprezinta un substring folosit pentru a inlocui unul existent
        private string newString;

        // reprezinta un substring ce urmeaza a fi inlocuit
        private string oldString;

        public ExecuteCommand(string text, string command, string help)
        {
            // se seteaza valori pentru proprietatile clasei
            this.SetsPropertyValues(command);
            
            // se executa instructiunile asociate comenzii primite de la user
            switch (this.command)
            {
                case "upper":
                    Console.WriteLine($"upper > {text.ToUpper()}\n");
                    break;
                case "lower":
                    Console.WriteLine($"lower > {text.ToLower()}\n");
                    break;
                case "length":
                    Console.WriteLine($"length > {text.Length}\n");
                    break;
                case "index of":
                    Console.WriteLine($"index of > {text.IndexOf(this.subString)}\n");
                    break;
                case "replace":
                    Console.WriteLine($"new > {text.Replace(this.oldString, this.newString)}\nold > {text}\n");
                    break;
                case "text":
                    Console.WriteLine($"text > {text}\n");
                    break;
                case "help":
                    Console.WriteLine(help);
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("  Aceasta nu este o comanda valida, pentru a vedea comenzile tasteaza: help >");
                    break;
            }
        }

        // metoda care seteaza valori pentru proprietatile clasei
        private void SetsPropertyValues(string command)
        {
            string[] commandParts = command.Split('>');
            string firstPart = commandParts[0].Trim();

            if (commandParts.Length > 1)
            {
                string secondPart = commandParts[1].Trim();

                if (!string.IsNullOrEmpty(secondPart))
                {
                    string[] userInput = secondPart.Split(',');
                    this.subString = userInput[0].Trim();

                    if (userInput.Length > 1)
                    {
                        this.oldString = userInput[0].Trim();
                        this.newString = userInput[1].Trim();
                    }
                }
            }
            
            this.command = firstPart;
        }
    }
}
