using System.Collections.Generic;
using System.Linq;

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
        };


        public static decimal Calculate(List<DishColor> basket)
        {
            if (basket.Any())
            {
                return pricelist[basket.First()];
            }

            return 0m;
        }
    }
}