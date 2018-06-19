using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01Library
{
    // clasa Brain are evenimente care sunt apelate atunci cand utilizatorul scrie o comanda
    public class Brain
    {
        // delegat care va fi folosit pentru toate metodele cu semnatura void si fara parametru din clasa Brain
        public delegate void VoidNoParameterBrainDelegate();

        // evenimente care sunt folosite pentru fiecare comanda in parte, fiecare declansand o actiune specifica comenzilor
        public event VoidNoParameterBrainDelegate ExitApplication;
        public event VoidNoParameterBrainDelegate FakeCommand;
        public event VoidNoParameterBrainDelegate HelpCommand;
        public event VoidNoParameterBrainDelegate CreateAccount;
        public event VoidNoParameterBrainDelegate LogIn;
        public event VoidNoParameterBrainDelegate AddPost;
        public event VoidNoParameterBrainDelegate ShowAllPost;
        public event VoidNoParameterBrainDelegate LogOut;

        // delegat cu semnatura void si un parametru short
        public delegate void ShowPostDelegate(short id);
        public event ShowPostDelegate ShowPost;

        // delegat cu semnatura void si un parametru string
        public delegate void WrongIdDelegate(string user);
        public event WrongIdDelegate WrongId;

        // proprietate care ia ca valoare comanda data de usser
        public static string Command { get; set; }
        // proprietate care ia ca valoare id-ul ce urmeaza a fi afisat
        private short PostId = -1;

        public void GetUserCommand(string command)
        {
            PrepareCommands(command);

            switch (Command)
            {
                case "ca":
                    OnCreateAccount();
                    break;
                case "lg in":
                    OnLogIn();
                    break;
                case "lg out":
                    OnLogOut();
                    break;
                case "add p":
                    OnAddPost();
                    break;
                case "show all":
                    OnShowAllPost();
                    break;
                case "show p":
                    OnShowPost(PostId);
                    break;
                case "help":
                    HelpCommand();
                    break;
                case "exit":
                    OnExitCommand();
                    break;
                default:
                    OnFakeCommand();
                    break;
            }
        }

        private void OnExitCommand()
        {
            if (ExitApplication != null)
            {
                ExitApplication();
            }
        }

        private void OnLogOut()
        {
            if (LogOut != null)
            {
                LogOut();
            }
        }

        private void OnShowPost(short id)
        {
            if (ShowPost != null)
            {
                ShowPost(id);
            }
        }

        private void OnShowAllPost()
        {
            if (ShowAllPost != null)
            {
                ShowAllPost();
            }
        }

        private void OnAddPost()
        {
            if (AddPost != null)
            {
                AddPost();
            }
        }

        private void OnFakeCommand()
        {
            if (FakeCommand != null)
            {
                FakeCommand();
            }
        }

        private void OnHelpCommand()
        {
            if (HelpCommand != null)
            {
                HelpCommand();
            }
        }

        private void OnCreateAccount()
        {
            if (CreateAccount != null)
            {
                CreateAccount();
            }
        }

        private void OnLogIn()
        {
            if (LogIn != null)
            {
                LogIn();
            }
        }

        private void OnWrongId(string user)
        {
            if (WrongId != null)
            {
                WrongId(user);
            }
        }

        private void PrepareCommands(string arg)
        {
            string[] command = arg.Trim().Split(' ');
            int commandLength = command.Length;

            switch (commandLength)
            {
                case 1:
                    Command = command[0];
                    break;
                case 2:
                    Command = $"{command[0]} {command[1]}";
                    break;
                case 3:
                    Command = $"{command[0]} {command[1]}";
                    try
                    {
                        PostId = short.Parse(command[2]);
                    }
                    catch
                    {
                        if(UserService.UserConnected != null)
                            OnWrongId(UserService.UserConnected);
                    }
                    break;
            }
        }
    }
}
