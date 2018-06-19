using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01Library
{
    // clasa User contine proprietatile unui user si da valoare acestora in constructor
    // clasa implementeaza interfata IPerson
    public class User : IPerson
    {
        public string FirstName { get; private set; }
        public string LastName { get; set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        private DateTime BirthDate { get; set; }
        private int Id { get; set; }
        public bool IsLogin = false;

        public User(int id, DateTime birthDate, params string[] args)
        {
            Id = id;
            BirthDate = birthDate;
            FirstName = args[0];
            LastName = args[1];
            Email = args[2];
            Password = args[3];
        }
    }
}
