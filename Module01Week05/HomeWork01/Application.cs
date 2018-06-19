using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork01Library;

namespace HomeWork01
{
    class Application
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            // se afiseaza comenzile pe care utilizatorul le poate da
            CommandLine.UserCommandLine();

            // se instantiaza  clasele Brain, UserService si MessageBoard folosind clasa Factory
            // clasa Brain are evenimente care sunt apelate atunci cand utilizatorul scrie o comanda
            Brain startApplication = Factory.CreateBrain();

            // clasa UserService descrie toate actiunile pe care un user le poate face in cadrul aplicatiei
            UserService userService = Factory.CreateUserService();

            // clasa MessageBoard descrie actiunile ce pot fi facute cu postarile existente
            MessageBoard postService = Factory.CreateMessageBoard();

            startApplication.ExitApplication += Exit.ExitApplication;
            startApplication.FakeCommand += StandardMessages.FakeCommand;
            startApplication.HelpCommand += CommandLine.UserCommandLine;
            startApplication.CreateAccount += userService.CreateAccount;
            startApplication.LogOut += userService.LogOut;
            startApplication.LogIn += userService.LogIn;
            startApplication.AddPost += userService.AddPost;
            startApplication.ShowAllPost += postService.ShowAllPost;
            startApplication.ShowPost += postService.ShowPost;
            startApplication.WrongId += StandardMessages.WrongId;
            userService.UserNotConnected += StandardMessages.UserNotConnected;
            userService.NewMessage += StandardMessages.NewPost;
            userService.NewPostIsAdded += postService.AddNewPost;
            postService.UserNotConnected += StandardMessages.UserNotConnected;
            postService.ShowPostById += DisplayPost.DisplayPostById;
            postService.ShowAllPosts += DisplayPost.DisplayAllPosts;

            string command = null;
            string getCommand;

            do
            {
                Console.Write($"  > ");

                // daca exista un user conectat numele lui va fi afisat in consola
                if(UserService.UserConnected != null)
                    Console.Write($"({UserService.UserConnected}): ");

                // se citeste comanda de la tastatura
                getCommand = UserCommand.Read();
                
                if (!string.IsNullOrEmpty(getCommand))
                {
                    // daca userul introduce o comanda care nu este nula se trimite ca parametru catre Brain
                    startApplication.GetUserCommand(getCommand);
                    command = Brain.Command;
                }
            }
            while (true);
        }
    }
}
