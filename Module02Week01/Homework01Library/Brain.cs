using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01Library
{
    public class Brain
    {
        // evenimente folosite in functie de comanda introdusa de user
        public event EventHandler DisplayNames;
        public event EventHandler FakeCommand;
        public event EventHandler EmptyName;
        public event EventHandler<string> LoadList;
        public event EventHandler<string> SaveList;
        public event EventHandler<string> AddName;
        public event EventHandler<string> RemoveName;

        // proprietate care primeste ca valoare comanda citita de la tastatura
        private string Command { get; set; }

        // proprietate care primeste ca valoare numele unei persoane sau fisier
        private string Name { get; set; }

        public void ExecuteCommand(string[] args)
        {
            SetPropertiesValue(args);

            switch (Command)
            {
                case "load":
                    OnLoadList(Name);
                    break;
                case "save":
                    OnSaveList(Name);
                    break;
                case "add":
                    OnAddName(Name);
                    break;
                case "remove":
                    OnRemoveName(Name);
                    break;
                case "display":
                    OnDisplayNames();
                    break;
                default:
                    OnFakeCommand();
                    break;
            }
        }

        // metoda care seteaza valorile proprietatilor Command si Name
        // argumentul metodei este un array de string-uri primit in Program de la Validate
        private void SetPropertiesValue(string[] args)
        {
            // Command primeste valoare
            Command = args[0].Trim();

            // daca comanda este una din urmatoarele 4 atunci va trebui sa primeasca valoare si Name
            if (
                Command == "load" ||
                Command == "save" ||
                Command == "add" ||
                Command == "remove"
                )
                if (args.Length != 1)
                    if (string.IsNullOrEmpty(args[1].Trim()))
                        Name = null;
                    else
                        if (args.Length == 2)
                            Name = args[1].Trim();
                        else if (args.Length == 3)
                            Name = args[1] + " " + args[2];
                        else
                            Name = args[1] + " " + args[2] + " " + args[3];
                else
                    Name = null;
        }

        private void OnEmptyName()
        {
            if (EmptyName != null)
            {
                EmptyName(this, EventArgs.Empty);
            }
        }

        private void OnFakeCommand()
        {
            if (FakeCommand != null)
            {
                FakeCommand(this, EventArgs.Empty);
            }
        }

        private void OnDisplayNames()
        {
            if (DisplayNames != null)
            {
                DisplayNames(this, EventArgs.Empty);
            }
        }

        private void OnLoadList(string name)
        {
            if (Name is null)
            {
                OnEmptyName();
                return;
            }
            if (LoadList != null)
            {
                LoadList(this, name);
            }
        }

        private void OnAddName(string name)
        {
            if (Name is null)
            {
                OnEmptyName();
                return;
            }
            if (AddName != null)
            {
                AddName(this, name);
            }
        }

        private void OnRemoveName(string name)
        {
            if (Name is null)
            {
                OnEmptyName();
                return;
            }
            if (RemoveName != null)
            {
                RemoveName(this, name);
            }
        }

        private void OnSaveList(string name)
        {
            if (Name is null)
            {
                OnEmptyName();
                return;
            }
            if (SaveList != null)
            {
                SaveList(this, name);
            }
        }
    }
}
