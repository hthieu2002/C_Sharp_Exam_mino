using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManaing_2
{
    public class BookComparerByAuthor : IComparer<IBook>
    {
        public int Compare(IBook x, IBook y)
        {
            return string.Compare(x.Author, y.Author);
        }
    }
}
