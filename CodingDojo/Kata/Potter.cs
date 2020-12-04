using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class Potter
    {
        private decimal _singleBookPrice = 8m;

        private decimal[] _discount = {0m, 1m, 0.95m, 0.9m, 0.8m, 0.75m};

        private decimal _discountTwoBooks   = 0.95m;
        private decimal _discountThreeBooks = 0.9m;
        private decimal _discountFourBooks  = 0.8m;

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