using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace KataPotter
{
    public class Potter
    {
        private const decimal SingleBookPrice = 8;

        public decimal Calculate(List<int> countOfDifferentBooks)
        {
            return countOfDifferentBooks.SingleOrDefault() * SingleBookPrice;
        }
    }
}