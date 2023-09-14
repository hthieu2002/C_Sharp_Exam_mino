using System;
using System.Collections.Generic;
using System.Collections;

namespace BookManaing_2
{
    public class Book : IBook
    {
        private string isbn;
        private string title;
        private string author;
        private string publisher;
        private int year;
        private List<string> chapters = new List<string>();

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < chapters.Count)
                {
                    return chapters[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 && index < chapters.Count)
                {
                    chapters[index] = value;
                }
                else if (index == chapters.Count)
                {
                    chapters.Add(value);
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
        public List<string> Chapters
        {
            get { return chapters; }
            set { chapters = value; }
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
            foreach (string chapterName in chapters)
            {
                Console.WriteLine(chapterName);
                Console.WriteLine("------------------------------------");
            }
        }

        public int CompareTo(IBook other)
        {
            return string.Compare(this.Title, other.Title);
        }
    }
}
