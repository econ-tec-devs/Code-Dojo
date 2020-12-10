// -----------------------------------------------------------------------
// <copyright file="Sushi.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;

namespace KataTest
{
    public class Sushi
    {

        public static decimal GetPrice(List<string> plates)
        {
            if (plates?.Count >=1)
            {
                return 0.95m;
            }
            return 0m;
        }
    }
}
