using System.Collections.Generic;
using System.Linq;

namespace KataTest
{
    public class Sushi
    {
        private static decimal priceNoDishes = 0m;
        private static decimal priceOneBlueDish = 0.95m;
        private static decimal priceOneRedDish = 1.95m;
        private static decimal priceOneYellowDish = 2.95m;
        private static decimal priceOneGreenDish = 3.95m;
        private static decimal priceOneGrayDish = 4.95m;

        public static decimal Calculate(List<DishColor> basket)
        {
            if (!basket.Any())
            {
                return priceNoDishes;
            }

            return basket.Sum(dish => GetPricePerDish(dish));
        }

        private static decimal GetPricePerDish(DishColor dish)
        {
            switch (dish)
            {
                case DishColor.Blue:
                    return priceOneBlueDish;
                case DishColor.Red:
                    return priceOneRedDish;
                case DishColor.Yellow:
                    return priceOneYellowDish;
                case DishColor.Green:
                    return priceOneGreenDish;
                case DishColor.Gray:
                    return priceOneGrayDish;
                default:
                    return priceNoDishes;
            }
        }
    }
}