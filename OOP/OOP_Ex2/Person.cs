using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ex2
{
    internal class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

    }
}
