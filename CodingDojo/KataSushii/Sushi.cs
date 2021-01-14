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
        public static decimal CalculatePrice(List<string> plates)
        {
            if (plates.Any())
            {
                return 0.95m;

            }
            return 0m;
        }
    }
}