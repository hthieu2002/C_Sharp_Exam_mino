using BookManaing_2;

public class BookList
{
    private List<IBook> list = new List<IBook>();

    public void AddBook(IBook book)
    {
        list.Add(book);
    }

    public void ShowList()
    {
        foreach (IBook book in list)
        {
            book.Show();
        }
    }

    public void InputList()
    {
        int n;
        Console.Write("Số lượng sách: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Book b = new Book();
            Console.WriteLine($"Nhập thông tin cho cuốn sách thứ {i + 1}:");
            Console.Write("Title : ");
            b.Title = Console.ReadLine();
            Console.Write("Author: ");
            b.Author = Console.ReadLine();
            Console.Write("Publisher: ");
            b.Publisher = Console.ReadLine();
            Console.Write("ISBN: ");
            b.ISBN = Console.ReadLine();
            Console.Write("Year: ");
            b.Year = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập các chương (kết thúc bằng dòng trống):");
            string chapterName;
            int chapterCount = 0; // Biến trung gian để theo dõi số lượng chương của cuốn sách
            while (!string.IsNullOrWhiteSpace(chapterName = Console.ReadLine()))
            {
                b[chapterCount] = chapterName;
                chapterCount++; // Tăng số lượng chương sau mỗi lần thêm
            }

            AddBook(b);
        }
    }




    public void SortByTitle()
    {
        list.Sort();
    }

    public void SortByAuthor()
    {
        list.Sort(new BookComparerByAuthor());
    }

    public void SortByYear()
    {
        list.Sort(new BookComparerByYear());
    }
}