using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManaging
{
    class BookList
    {
        private ArrayList list = new ArrayList();

        ///<summary>
        /// tạo một đối tượng sách, nhập các thông tin và thêm vào list
        /// </summary>
        /// 

        public void AddBook()
        {
            Book b = new Book();

            b.Input();
            list.Add(b);
        }

        ///<summary>
        ///xuất danh sách
        /// </summary>
        /// 

        public void ShowList()
        {
            foreach (Book b in list)
            {
                b.Show();
            }
        }

        public void InputList()
        {
            int n;
            Console.Write("Amount of books : ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                AddBook();
                n--;
            }
        }
    }
}
