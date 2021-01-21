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

            switch (basket[0])
            {
                case DishColor.Blue:
                    return 0.95m;
                case DishColor.Red:
                    return 1.95m;
                case DishColor.Yellow:
                    return 2.95m;
                case DishColor.Green:
                    return 3.95m;

                default:
                    return 0m;
            }
        }
    }
}