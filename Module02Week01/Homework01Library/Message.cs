using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01Library
{
    // clasa abstracta, metodele clasei vor fi implementate de clasa StandardMessage
    public abstract class Message
    {
        public abstract void WelcomeMessage();
        public abstract void MissingFileMessage();
        public abstract void DisplayBeforeLoaded();
        public abstract void InvalidFileNameMessage();
        public abstract void FakeCommandMessage(object sender, EventArgs e);
        public abstract void EmptyNameMessage(object sender, EventArgs e);
        public abstract void SuccessMessage();
        public abstract void SaveBeforeLoaded();
        public abstract void RemoveBeforeLoaded();
        public abstract void NameNotFound();
        public abstract void NameHasBeenDeleted();
        public abstract void InvalidPersonName();
    }
}
