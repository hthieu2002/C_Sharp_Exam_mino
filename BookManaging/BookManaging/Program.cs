using BookManaging;
class Program
{
    static void Main(string[] args)
    {
        BookList bl = new BookList();
        bl.InputList();
        bl.ShowList();
        Console.ReadLine();
    }
}

