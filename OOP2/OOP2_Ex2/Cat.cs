using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Ex2
{
     class Cat: Animal
    {
        public Cat(string name) : base("Mammal")
        {
            Name = name;
        }

        public void Climb(string thing)
        {
            Console.WriteLine($"{Name} is climbing {thing}.");
        }

        public override string MakeSound()
        {
            return "Meow Meow!";
        }
    }
}
