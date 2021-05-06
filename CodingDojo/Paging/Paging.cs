// -----------------------------------------------------------------------
// <copyright file="Paging.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Paging7
{
    public class Paging
    {
        public string ShowPaging(int currentPage, int maxPage)
        {
            if (maxPage == 1)
            {
                return $"({currentPage})";
            }

            return $"({currentPage}) {maxPage}";
        }
    }
}
