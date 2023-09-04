
using OPP2_Ex1;

class Program
{
    static void Main(string[] args)
    {
        Shape[] shapes = {
            new Line(0, 0, 5, 5),
            new Circle(10, 10, 7),
            new Rectangle(2, 2, 8, 2, 8, 8),
            new PolyLine(new int[] { 1, 3, 5, 7 }, new int[] { 2, 4, 6, 8 })
        };

        foreach (var shape in shapes)
        {
            shape.Show();
            shape.Move(1, 1);
            shape.Show();
            Console.WriteLine();
        }
    }
}