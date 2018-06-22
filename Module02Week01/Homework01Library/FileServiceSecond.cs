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
        protected override void WriteToFile(string fileName, FileMode fileMode, FileAccess fileAccess)
        {
            FileStream fileStream = new FileStream(fileName, fileMode, fileAccess);
            foreach (var name in Names)
            {
                if (Validate.IsValidName(name.Trim().ToCharArray()))
                {
                    byte[] nameChars = Encoding.ASCII.GetBytes(name + NewLine);

                    foreach (var letter in nameChars)
                    {
                        fileStream.WriteByte(letter);
                    }
                }
            }
            fileStream.Close();
        }
    }
}
