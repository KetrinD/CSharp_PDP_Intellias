using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Lab2_Inheritance
{
    // 1.Create a Person base class with common attributes for a person
    public abstract class APerson 
    {
        public string FullName { get; private set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public DateTime Birthdate { get; set; }


        protected APerson(string firstName, string lastName, DateTime birthdate)
        {
            FirstName = firstName;
            LastName = lastName;
            FullName = firstName + " " + lastName;
            Birthdate = birthdate;
        }
    }
}
