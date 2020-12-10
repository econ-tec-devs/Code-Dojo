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
            if (plates?.Count == 2)
            {
                return 0.95m * 2;
            }

            if (plates?.Count >= 1)
            {
                return 0.95m;
            }

            return 0m;
        }
    }
}
