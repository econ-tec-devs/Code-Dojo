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
                if (books.Count == 2)
                {
                    return _singleBookPrice * books.Last();
                }

                return _singleBookPrice * books.First();
            }

            return 0m;
        }
    }
}