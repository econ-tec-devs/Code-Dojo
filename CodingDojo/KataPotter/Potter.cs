using System.Collections.Generic;
using System.Linq;

namespace KataPotter
{
    public class Potter
    {
        private const decimal SingleBookPrice = 8;

        public decimal Calculate(List<int> countOfDifferentBooks)
        {
            if (countOfDifferentBooks.Count ==2)
            {
                return countOfDifferentBooks.Last() * SingleBookPrice;
            }
            
            return countOfDifferentBooks.SingleOrDefault() * SingleBookPrice;
        }
    }
}