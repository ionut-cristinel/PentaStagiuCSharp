using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01Library
{
    // clasa abstracta Service care este mostenita de clasa UserService
    // clasa are 4 metode folosite de UserService si care reprezinta actiunile facute de user
    public abstract class Service
    {
        // creaza un cont nou
        public abstract void CreateAccount();
        // conecteaza userul in aplicatie
        public abstract void LogIn();
        // adauga o postare noua
        public abstract void AddPost();
        // deconecteaza userul
        public abstract void LogOut();
    }
}
