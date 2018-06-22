using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework01Library
{
    // FileService implementeaza metodele definite in File
    // FileService executa operatiunile de scriere si citire din fisier sau il creaza daca nu exista
    // FileService adauga sau sterge numele unei persoane
    public partial class FileService : File
    {
        // constanta care reprezinta locatia fisierelor in care se lucreaza fata de .exe
        private const string FileLevels = "../../";

        // constanta care reprezinta caracterul escape pentru a trece pe un rand nou
        private const string NewLine = "\n";

        // lista cu numele incarcate dintr-un fisier sau adaugate de la tastatura
        private List<string> Names { get; set; }

        // fisierul din care se vor incarca numele persoanelor in lista Names
        private string UploadFile { get; set; }

        // fisierul in care se vor salva numele persoanelor din lista Names
        private string FileToSave { get; set; }

        // proprietatea Message va primi ca valoare instanta creata la StandardMessage
        // valoarea o va primi in constructor
        // proprietatea este folosita pentru afisarea mesajelor din StandardMessage
        private Message Message { get; set; }

        public FileService(Message message)
        {
            Message = message;
        }

        // metoda utilizata pentru a aduga in Names numele dintr-un fisier
        public override void LoadListFromFile(object sender, string name)
        {
            // UploadFile primeste ca valoare calea fisierului din care se va citi
            UploadFile = Path.GetFullPath(FileLevels + name);
            try
            {
                StreamReader file = new StreamReader(UploadFile);

                // daca Names este null va fi initiat
                if(Names is null)
                    Names = new List<string>();

                string line;

                // fisierul este citit linie cu linie
                while ((line = file.ReadLine()) != null)
                {
                    // daca linia curenta nu este goala se adauga in Names
                    if(!string.IsNullOrEmpty(line))
                        Names.Add(line);
                }
                Message.SuccessMessage();
            }
            catch (FileNotFoundException)
            {
                Message.MissingFileMessage();
            }
        }

        // metoda care salveaza numele persoanelor intr-un fisier
        public override void SaveToFile(object sender, string name)
        {
            // daca fisierul in care sa vor salva numele din Names nu este .txt procesul va fi oprit
            if (Path.GetExtension(name) != ".txt")
            {
                Message.InvalidFileNameMessage();
                return;
            }

            // daca Names nu are nici un nume care sa poata fi salvat procesul este oprit
            if (Names == null)
            {
                Message.SaveBeforeLoaded();
                return;
            }

            // FileToSave primeste ca valoare fisierul in care se vor salva numele din Names
            FileToSave = Path.GetFullPath(FileLevels + name);

            try
            {
                // daca fisierul exista se apeleaza metoda WriteToFile pentru a scrie in fisier
                WriteToFile(FileToSave, FileMode.Open, FileAccess.Write);
            }
            catch (FileNotFoundException)
            {
                // daca fisierul nu exista se apeleaza metoda WriteToFile pentru crea fisierul si dupa scrie in el
                WriteToFile(FileToSave, FileMode.OpenOrCreate, FileAccess.Write);
            }
            finally
            {
                Message.SuccessMessage();
            }
        }

        // metoda care afiseaza in consola numele din Names
        public override void DisplayNames(object sender, EventArgs e)
        {
            // daca Names are cel putin un nume se va afisa in consola
            // altfel se va apela metoda din catch
            try
            {
                foreach (var name in Names)
                {
                    Console.WriteLine("  > {0}", name);
                }
            }
            catch (NullReferenceException)
            {
                Message.DisplayBeforeLoaded();
            }
        }

        // metoda care adauga un nume nou in lista Names
        public override void AddNewName(object sender, string name)
        {
            // daca lista Names e nula este creata acum
            if (Names is null)
                Names = new List<string>();
            // daca numele este unul valid se adauga in lista
            if (Validate.IsValidName(name.Trim().ToCharArray()))
            {
                Names.Add(name);
                Message.SuccessMessage();
            }
            else
                Message.InvalidPersonName();
        }

        // metoda care sterge un nume din lista Names
        public override void RemoveName(object sender, string name)
        {
            // se verifica daca lista are elemente pentru a putea fi sterse
            if(Names is null)
            {
                Message.RemoveBeforeLoaded();
                return;
            }

            // se parcurge iterativ lista
            // daca numele ce trebuie sters este gasit va fi eliminat din Names
            foreach (var nameList in Names)
            {
                if (nameList == name)
                {
                    Names.Remove(name);
                    Message.NameHasBeenDeleted();
                    return;
                }
            }
            Message.NameNotFound();
        }
    }
}
