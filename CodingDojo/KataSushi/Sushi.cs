using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace KataSushi
{
    public class Sushi
    {
        private static decimal bluePrice = 0.95m;

        public static decimal CalculatePrice(Dictionary<string, int> dishes)
        {
            dishes.TryGetValue("blue", out int value);
            return value * bluePrice;
        }
    }
}