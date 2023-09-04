using System;

namespace OOP_Ex2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter person's name: ");
            string personName = Console.ReadLine();

            Console.Write("Enter person's age: ");
            int personAge = int.Parse(Console.ReadLine());

            Console.Write("Enter student's GPA: ");
            double studentGpa = double.Parse(Console.ReadLine());

            Person person = new Person(personAge, personName);
            Student student = new Student(personAge, personName, studentGpa);

            Console.WriteLine("\nPerson Information:");
            person.DisplayInfo();

            Console.WriteLine("\nStudent Information:");
            student.DisplayStudentInfo();
        }
    }
}

