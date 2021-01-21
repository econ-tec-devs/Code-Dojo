using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class Sushi
    {
        private static decimal priceBlueDish = 0.95m;

        public static decimal Calculate(List<DishColor> basket)
        {
            if (basket.Any())
            {
                return priceBlueDish;
            }
            return 0m;
        }
    }
}