using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework01Library
{
    public class User : Person
    {
        private Guid _id;
        public string Username { get; set; }

        public User()
        {

        }

        public User(string firstName, string lastName, Gender gender, DateTime birthDate) : base(firstName, lastName, gender, birthDate)
        {
            this._id = Guid.NewGuid();
        }
    }
}

