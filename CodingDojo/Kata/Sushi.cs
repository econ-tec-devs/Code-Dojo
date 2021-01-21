using System;
using System.Collections.Generic;

namespace Kata
{
    public class Sushi
    {
        private static Dictionary<DishColor, decimal> pricelist = new Dictionary<DishColor, decimal>()
        {
            {DishColor.Blue, 0.95m},
            {DishColor.Red, 1.95m},
            {DishColor.Yellow, 2.95m},
            {DishColor.Green, 3.95m},
            {DishColor.Grey, 4.95m},
        };

        public static decimal Calculate(List<DishColor> basket)
        {
            var sum = 0m;

            foreach (var item in basket)
            {
                sum += pricelist[item];
            }

            return sum;
        }
    }
}