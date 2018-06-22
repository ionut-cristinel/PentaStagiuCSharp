using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework01Library
{
    // clasa abstracta File defineste metode care sunt implementate in clasa FileService
    public abstract class File
    {
        public abstract void LoadListFromFile(object sender, string name);
        public abstract void SaveToFile(object sender, string name);
        public abstract void AddNewName(object sender, string name);
        public abstract void RemoveName(object sender, string name);
        public abstract void DisplayNames(object sender, EventArgs e);

        protected abstract void WriteToFile(string name, FileMode fileMode, FileAccess fileAccess);
    }
}
