using System.Collections.Generic;

namespace KataTest
{
    public class Sushi
    {
        private static decimal blueDishPrice= 0.95m;

        public static decimal CalculateFullPrice(Dictionary<string, int> dishes)
        {
            if (dishes.Count==1)
            {
                return dishes.Count * blueDishPrice;
            }
            
            return 0m;
        }
    }
}