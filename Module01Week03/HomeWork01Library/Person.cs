using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01Library
{
    public abstract class Person
    {
        protected string Email { get; set; }
        protected string FirstName { get; set; }
        protected string LasttName { get; set; }
        protected DateTime BirthDate { get; set; }

        protected abstract bool CreateAccount();
    }
}
