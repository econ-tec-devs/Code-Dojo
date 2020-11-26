using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace KataPotter
{
    public class Potter
    {
        private decimal bookPrice = 8;

        public decimal Calculate(List<int> countOfDifferentBooks)
        {
            return countOfDifferentBooks.SingleOrDefault() * bookPrice;
        }
    }
}