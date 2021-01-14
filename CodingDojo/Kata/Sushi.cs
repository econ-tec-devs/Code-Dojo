using System.Collections.Generic;

namespace KataTest
{
    public class Sushi
    {
        public static decimal CalculateFullPrice(Dictionary<string, int> dishes)
        {
            if (dishes.Count==1)
            {
                return dishes.Count * 0.95m;
            }
            
            return 0m;
        }
    }
}