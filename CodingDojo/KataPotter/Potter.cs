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
            if (countOfDifferentBooks.Count ==2)
            {
                return countOfDifferentBooks.Last() * bookPrice;
            }
            
            return countOfDifferentBooks.SingleOrDefault() * bookPrice;
        }
    }
}