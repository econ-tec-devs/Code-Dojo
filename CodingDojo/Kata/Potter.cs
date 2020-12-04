using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class Potter
    {
        public decimal Calculate(List<int> books)
        {
            if (books.Any())
            {
                return 8m;
            }

            return 0m;
        }
    }
}