using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManaing_2
{
    public class BookComparerByYear : IComparer<IBook>
    {
        public int Compare(IBook x, IBook y)
        {
            return x.Year - y.Year;
        }
    }
}
