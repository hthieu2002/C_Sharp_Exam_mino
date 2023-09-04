using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Ex2
{
     class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, string breed) : base("Mammal")
        {
            Name = name;
            Breed = breed;
        }

        public override string MakeSound()
        {
            return "Woof Woof!";
        }
    }
}
