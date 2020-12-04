using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class Potter
    {
        private decimal _singleBookPrice = 8m;

        public decimal Calculate(List<int> books)
        {
            var filteredBooks = books.Where(x => x > 0).ToList();

            if (filteredBooks.Any())
            {
                return _singleBookPrice * filteredBooks.First();
            }

            return 0m;
        }
    }
}