// -----------------------------------------------------------------------
// <copyright file="Sushi.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataSushii
{
    using System.Collections.Generic;

    public class Sushi
    {
        private const decimal PriceBlue = 0.95m;
        private const decimal PriceRed = 1.95m;

        public static decimal CalculatePrice(Dictionary<string, int> plates)
        {
            var price = 0m;

            foreach (var pair in plates)
            {
                if (pair.Key == "blue")
                {
                    price += pair.Value * PriceBlue;
                }

                if (pair.Key == "red")
                {
                    price += pair.Value * PriceRed;
                }
            }

            return price;
        }
    }
}
