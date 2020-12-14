using System.Collections.Generic;

namespace KataSushi
{
    public class Sushi
    {
        private static decimal bluePrice = 0.95m;
        private static decimal redPrice = 1.95m;
        private static decimal yellowPrice = 2.95m;
        private static decimal greenPrice = 3.95m;
        private static decimal greyPrice = 4.95m;

        public static decimal CalculatePrice(Dictionary<string, int> dishes)
        {
            var price = 0m;
            dishes.TryGetValue("grey", out var valueGrey);
            price += valueGrey * greyPrice;
            dishes.TryGetValue("green", out var valueGreen);
            price += valueGreen * greenPrice;
            dishes.TryGetValue("yellow", out var valueYellow);
            price += valueYellow * yellowPrice;
            dishes.TryGetValue("red", out var valueRed);
            price += valueRed * redPrice;
            dishes.TryGetValue("blue", out var valueBlue);
            price += valueBlue * bluePrice;

            return price;
        }
    }
}