using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }

        public string Address { get; set; }
        public string City { get; set; }
        public DateTime Birthday { get; set; }

        public Student(string name, string surname)
        {
            FirstName = name;
            LastName = surname;
        }

       public Hashtable Grades = new Hashtable();

        public override string ToString()
        {
            return "Student FullName: " + FullName;
        }
    }
}
