using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class Potter
    {
        private decimal _singleBookPrice = 8m;

        public decimal Calculate(List<int> books)
        {
            if (books.Any())
            {
                
                return _singleBookPrice;
            }

            return 0m;
        }
    }
}