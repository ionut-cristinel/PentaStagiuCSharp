using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01Library
{
    // clasa User mosteneste Person 
    // User are 3 proprietati in plus fata de Person
    class User : Person
    {
        private int Id { get; set; }
        public string Password { get; set; }
        public bool IsLogIn { get; set; }

        public User(int id, DateTime birthDate, bool islogin, params string[] args) : base(birthDate, args)
        {
            this.Id = id;
            this.Password = args[3];
            this.IsLogIn = false;
        }
    }
}
