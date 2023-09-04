using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ex2
{
    internal class Student : Person
    {
        public double GPA { get; set; }

        public Student(int age, string name, double gpa) : base(age, name)
        {
            GPA = gpa;
        }

        public void DisplayStudentInfo()
        {
            DisplayInfo();
            Console.WriteLine($"GPA: {GPA}");
        }
    }
}
