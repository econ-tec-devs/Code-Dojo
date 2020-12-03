// -----------------------------------------------------------------------
// <copyright file="Potter.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataTest
{
    using System.Collections.Generic;

    public class Potter
    {
        public decimal Calculate(List<int> countOfSameBooks)
        {
            var priceOneBook = 8m;
            if (countOfSameBooks.Count == 2)
            {
                return priceOneBook * 2 * 0.95m;
            }

            if (countOfSameBooks.Count != 0)
            {
                return priceOneBook * countOfSameBooks[0];
            }

            return 0;
        }
    }
}
