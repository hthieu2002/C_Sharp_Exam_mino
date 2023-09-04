
using OOP2_Ex2;

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Buddy", "Collie");
        Cat cat = new Cat("Whiskers");
        Duck duck = new Duck("Daffy");

        Console.WriteLine(dog.GetInfo());
        Console.WriteLine($"Sound: {dog.MakeSound()}");
        Console.WriteLine();

        Console.WriteLine(cat.GetInfo());
        Console.WriteLine($"Sound: {cat.MakeSound()}");
        cat.Climb("tree");
        Console.WriteLine();

        Console.WriteLine(duck.GetInfo());
        Console.WriteLine($"Sound: {duck.MakeSound()}");
        duck.Swim("pond");
    }
}