using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Ex2
{
     class Duck : Animal
    {
        public Duck(string name) : base("Bird")
        {
            Name = name;
        }

        public void Swim(string place)
        {
            Console.WriteLine($"{Name} is swimming in {place}.");
        }

        public override string MakeSound()
        {
            return "Quack Quack!";
        }
    }
}
