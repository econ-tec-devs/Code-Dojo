using System.Collections.Generic;
using System.Linq;

namespace KataTest
{
    public class Sushi
    {
        public static decimal Calculate(List<DishColor> basket)
        {
            if (!basket.Any())
            {
                return 0m;
            }

            if (basket[0] == DishColor.Blue)
            {
                return 0.95m;
            }

            if (basket[0] == DishColor.Red)
            {
                return 1.95m;
            }

            return 0m;
        }
    }
}