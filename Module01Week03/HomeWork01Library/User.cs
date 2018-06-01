using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01Library
{
    class User : Person
    {
        private int Id { get; set; }
        private string Password { get; set; }

        protected override bool CreateAccount()
        {
            throw new NotImplementedException();
        }

        private bool LogIn()
        {
            throw new NotImplementedException();
        }

        private bool PostMessage()
        {
            throw new NotImplementedException();
        }
    }
}
