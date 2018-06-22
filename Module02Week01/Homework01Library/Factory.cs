using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01Library
{
    // Factory este utilizata cu scopul de a crea intr-un singur loc toate obiectele aplicatiei
    public static class Factory
    {
        public static Message CreateStandardMessage()
        {
            return new StandardMessage();
        }

        public static Brain CreateBrain()
        {
            return new Brain();
        }

        public static File CreateFileService(Message message)
        {
            return new FileService(message);
        }
    }
}
