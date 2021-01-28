using System.Collections.Generic;
using System.Linq;

namespace KataTest
{
    public class Sushi
    {
        private static Dictionary<DishColor, decimal> priceList = new Dictionary<DishColor, decimal>()
        {
            {DishColor.Blue, 0.95m},
            {DishColor.Red, 1.95m},
            {DishColor.Yellow, 2.95m},
            {DishColor.Green, 3.95m},
            {DishColor.Gray, 4.95m}
        };

        public static decimal Calculate(List<DishColor> basket)
        {
            decimal sum = 0;
            foreach (var dish in basket)
            {
                sum += priceList[dish];
            }

            return sum;
        }
    }
}