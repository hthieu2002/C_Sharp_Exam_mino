using BookManaing_2;
using System;

namespace BookManaging_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BookList bl = new BookList();
            bl.InputList();

            // Sắp xếp theo tiêu đề sách
            Console.WriteLine("Danh sách sách theo tiêu đề:");
            bl.SortByTitle();
            bl.ShowList();

            // Sắp xếp theo tên tác giả
            Console.WriteLine("Danh sách sách theo tên tác giả:");
            bl.SortByAuthor();
            bl.ShowList();

            // Sắp xếp theo năm xuất bản
            Console.WriteLine("Danh sách sách theo năm xuất bản:");
            bl.SortByYear();
            bl.ShowList();

            Console.ReadLine();
        }
    }
}
