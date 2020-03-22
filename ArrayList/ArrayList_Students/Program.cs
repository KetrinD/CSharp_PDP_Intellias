using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Students
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student("Ketrin", "Shynkarenko");
            if (!(student1.Grades.ContainsKey("History") || student1.Grades.ContainsKey("Math") || student1.Grades.ContainsKey("Biology")  || student1.Grades.ContainsKey("Music") || student1.Grades.ContainsKey("Chemistry")))
            {
                student1.Grades.Add("History", 4);
                student1.Grades.Add("Math", 5);
                student1.Grades.Add("Biology", 4);
                student1.Grades.Add("Music", 5);
                student1.Grades.Add("Chemistry", 4);
            }

            Student student2 = new Student("Iryna", "Mazjarko");
            if (!(student2.Grades.ContainsKey("History") || student2.Grades.ContainsKey("Math") || student2.Grades.ContainsKey("Biology") || student2.Grades.ContainsKey("Music") || student2.Grades.ContainsKey("Chemistry")))
            {
                student2.Grades.Add("History", 4);
                student2.Grades.Add("Math", 5);
                student2.Grades.Add("Biology", 4);
                student2.Grades.Add("Music", 5);
                student2.Grades.Add("Chemistry", 4);
            }

            Student student3 = new Student("Olga", "Darmohval");
            if (!(student3.Grades.ContainsKey("History") || student3.Grades.ContainsKey("Math") || student3.Grades.ContainsKey("Biology") || student3.Grades.ContainsKey("Music") || student3.Grades.ContainsKey("Chemistry")))
            {
                student3.Grades.Add("History", 4);
                student3.Grades.Add("Math", 5);
                student3.Grades.Add("Biology", 4);
                student3.Grades.Add("Music", 5);
                student3.Grades.Add("Chemistry", 4);
            }

            ArrayList students = new ArrayList();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

            foreach (object obj in students)
            {
                Console.WriteLine(obj.ToString());
            }

            Console.ReadKey();



        }
    }
}
