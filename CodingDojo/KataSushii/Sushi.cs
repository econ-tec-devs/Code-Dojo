// -----------------------------------------------------------------------
// <copyright file="Sushi.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace KataSushii
{
    public class Sushi
    {
        private static decimal priceBlue = 0.95m;

        public static decimal CalculatePrice(Dictionary<string, int> plates)
        {
            if (plates.Any())
            {
                foreach (var pair in plates)
                {
                    if (pair.Key == "blue")
                    {
                        return pair.Value * priceBlue;
                    }
                }
            }
            return 0m;
        }
    }
}