// -----------------------------------------------------------------------
// <copyright file="Sushi.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataTest
{
    using System.Collections.Generic;

    public class Sushi
    {
        public static decimal GetPrice(List<string> plates)
        {
            if (plates == null)
            {
                return 0;
            }

            var priceOneGreyPlate = 1.95m;
            var priceOneBluePlate = 0.95m;

            if (plates.Contains("red"))
            {
                return priceOneGreyPlate * plates.Count;
            }

            return priceOneBluePlate * plates.Count;
        }
    }
}
