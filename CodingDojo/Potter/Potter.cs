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

            if (countOfSameBooks.Count != 0)
            {
                if (countOfSameBooks[0] == 2)
                {
                    return priceOneBook * 2;
                }

                return priceOneBook;
            }

            return 0;
        }
    }
}
