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
            decimal price = 0;

            if (countOfSameBooks.Count == 2 && countOfSameBooks[0] == 0)
            {
                return priceOneBook * countOfSameBooks[1];
            }

            if (countOfSameBooks.Count == 2)
            {
                price = priceOneBook * 2 * 0.95m;
            }

            if (countOfSameBooks.Count == 1)
            {
                price = priceOneBook * countOfSameBooks[0];
            }

            return price;
        }
    }
}
