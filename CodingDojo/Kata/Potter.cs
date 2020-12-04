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
            var filteredBooks = books.Where(x => x > 0).ToList();

            if (filteredBooks.Count > 1)
            {
                return _singleBookPrice * filteredBooks.Count * _discount[filteredBooks.Count];
            }
            
            if (filteredBooks.Any())
            {
                return _singleBookPrice * filteredBooks.First();
            }

            return 0m;
        }
    }
}