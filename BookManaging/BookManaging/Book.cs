using System.Collections;

namespace BookManaging
{
    class Book : IBook
    {
        #region Định nghĩa dữ liệu

        private string isbn;
        private string title;
        private string author;
        private string publisher;
        private int year;

        // Lưu trữ mảng chứa tên chương
        private ArrayList chapter = new ArrayList();

        #endregion

        #region Thực thi giao diện IBook

        public string this[int index] // Indexer chương sách
        {
            get
            {
                if (index >= 0 && index < chapter.Count)
                {
                    return (string)chapter[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 && index < chapter.Count)
                {
                    chapter[index] = value; // Cập nhật lại chương
                }
                else if (index == chapter.Count)
                {
                    chapter.Add(value);
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public void Show()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Publisher: " + Publisher);
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Chapters:");
            foreach (string chapterName in chapter)
            {
                Console.WriteLine(chapterName);
                Console.WriteLine("------------------------------------");
            }
        }

        #endregion

        public void Input()
        {
            Console.Write("Title : ");
            title = Console.ReadLine();
            Console.Write("Author: ");
            author = Console.ReadLine();
            Console.Write("Publisher: ");
            publisher = Console.ReadLine();
            Console.Write("ISBN: ");
            isbn = Console.ReadLine();
            Console.Write("Year: ");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine("Input chapter (finished with emty string )");

            string str;
            do
            {
                str = Console.ReadLine();
                if (str.Length >0)
                {
                    chapter.Add(str);
                }

            }while (str.Length > 0);
        }
    }
}
