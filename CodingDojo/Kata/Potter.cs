using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class Potter
    {
        private readonly decimal _singleBookPrice = 8m;
        private readonly decimal[] _discount = {0m, 1m, 0.95m, 0.9m, 0.8m, 0.75m};

        public decimal Calculate(List<int> books)
        {
            var price = 0m;
            var filteredBooks = books.Where(x => x > 0).ToList();

            while (filteredBooks.Any())
            {
                price += _singleBookPrice * filteredBooks.Count * _discount[filteredBooks.Count];
                filteredBooks = RemoveBundle(filteredBooks, filteredBooks.Count);
            }
            
            return price;
        }

        private List<int> RemoveBundle(List<int> filteredBooks, int filteredBooksCount)
        {
            for (int index = 0; index < filteredBooksCount; index++)
            {
                filteredBooks[index]--;
            }

            return filteredBooks.Where(x => x > 0 ).ToList();
        }

        private static bool IsBundle(List<int> filteredBooks)
        {
            return filteredBooks.Count > 1;
        }
    }
}