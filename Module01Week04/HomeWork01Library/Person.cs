using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01Library
{
    // clasa abstracta care defineste proprietatile persoanelor ce isi pot face cont in aplicatie
    public abstract class Person
    {
        protected string Email { get; set; }
        public string FirstName { get; set; }
        private string LastName { get; set; }
        protected DateTime BirthDate { get; set; }

        public Person(DateTime birthDate, params string[] args)
        {
            this.FirstName = args[0];
            this.LastName = args[1];
            this.Email = args[2];
        }
    }
}
