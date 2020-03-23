using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Lab2_Inheritance
{
    // 2.Make your Student and Teacher classes inherit from the Person base class
    // 3.Modify your Student and Teacher classes so that they inherit the common attributes from Person
    public class Teacher : APerson
    {
        public Teacher(string firstName, string lastName, DateTime birthdate)
            : base(firstName, lastName, birthdate) { }

        // 4.Modify your Student and Teacher classes so they include characteristics specific to their type.
        public void GradeTest()
        {
            Console.WriteLine("Teacher grades the test.");
        }

        public override string ToString()
        {
            return "Teacher FullName: " + FullName;
        }
    }
}
