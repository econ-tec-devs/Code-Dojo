using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class Sushi
    {
        public static decimal Calculate(List<DishColor> basket)
        {
            if (basket.Any())
            {
                return 0.95m;
            }
            return 0m;
        }
    }
}