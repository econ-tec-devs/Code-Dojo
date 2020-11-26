using System.Collections.Generic;

namespace KataPotter
{
    public class Potter
    {
        public decimal Calculate(List<int> countOfDifferentBooks)
        {
            if (countOfDifferentBooks.Count == 1)
            {
                return 8m;
            }
            return 0;
        }
    }
}