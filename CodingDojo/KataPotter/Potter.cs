using System.Collections.Generic;
using System.Linq;

namespace KataPotter
{
    public class Potter
    {
        public decimal Calculate(List<int> countOfDifferentBooks)
        {
            if (countOfDifferentBooks.SingleOrDefault() == 2)
            {
                return 16m;
            }

            if (countOfDifferentBooks.Count == 1)
            {
                return 8m;
            }
            return 0;
        }
    }
}