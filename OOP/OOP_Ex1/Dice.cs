using System;

namespace OOP_Ex1
{
    class Dice
    {
        private int sides;
        private Random random;

        public Dice(int sides)
        {
            this.sides = sides;
            random = new Random();
        }

        public int Roll()
        {
            return random.Next(1, sides + 1);
        }
    }
}

