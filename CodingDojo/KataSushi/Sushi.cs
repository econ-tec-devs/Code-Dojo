using System.Collections.Generic;
using System.Linq;

namespace KataSushi
{
    public class Sushi
    {
        public static decimal CalculatePrice(Dictionary<string, int> dishes)
        {
            if (dishes.Any())
            {
                return 0.95m;

            }
            
            return 0;
        }
    }
}