using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Lab2_Inheritance
{
    class Student : APerson
    {
        public Student(string firstName, string lastName, DateTime birthdate)
            : base(firstName, lastName, birthdate) { }

        // 4.Modify your Student and Teacher classes so they include characteristics specific to their type.
        public void TakeTest()
        {
            Console.WriteLine("Student takes the test.");
        }

        public override string ToString()
        {
            return "Student FullName: " + FullName;
        }
    }
}
