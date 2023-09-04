using System;

namespace OOP_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of sides for the dice: ");
            int sides = int.Parse(Console.ReadLine());

            Dice dice = new Dice(sides);
            int result = dice.Roll();

            Console.WriteLine($"The result of the roll is: {result}");
        }
    }
}

