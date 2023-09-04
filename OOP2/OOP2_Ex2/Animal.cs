using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Ex2
{
    abstract class Animal
    {
        public string Type { get; }
        public string Name { get; set; }

        public Animal(string type)
        {
            Type = type;
        }

        public abstract string MakeSound();
        public virtual string GetInfo()
        {
            return $"Type: {Type}, Name: {Name}";
        }
    }
}
