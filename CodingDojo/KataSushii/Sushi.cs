// -----------------------------------------------------------------------
// <copyright file="Sushi.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataSushii
{
    using System.Collections.Generic;
    using System.Linq;

    public class Sushi
    {
        private static decimal priceBlue = 0.95m;
        private static decimal priceRed = 1.95m;

        public static decimal CalculatePrice(Dictionary<string, int> plates)
        {
            var price = 0m;
            if (plates.Any())
            {
                foreach (var pair in plates)
                {
                    if (pair.Key == "blue")
                    {
                        price += pair.Value * priceBlue;
                    }

                    if (pair.Key == "red")
                    {
                        price += pair.Value * priceRed;
                    }
                }
            }

            return price;
        }
    }
}
