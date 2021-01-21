using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class Sushi
    {
        private static decimal priceBlueDish = 0.95m;
        private static decimal priceRedDish = 1.95m;
        private static decimal priceYellowDish = 2.95m;

        public static decimal Calculate(List<DishColor> basket)
        {

            if (basket.Any())
            {
                switch (basket.First())
                {
                    case DishColor.Red:
                        return priceRedDish;
                    case DishColor.Blue:
                        return priceBlueDish;
                    case DishColor.Yellow:
                        return priceYellowDish;
                }
            }

            return 0m;
        }
    }
}