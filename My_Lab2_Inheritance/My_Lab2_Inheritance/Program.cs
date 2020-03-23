using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Lab2_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ketrin", "Shynkarenko", new DateTime(1987, 12, 05));
            Teacher teacher1 = new Teacher("Oleg", "Zarevych", new DateTime(1988, 05, 15));

            Console.WriteLine(student1.ToString());
            Console.WriteLine(teacher1.ToString());
            Console.ReadKey();

        }
    }
}
