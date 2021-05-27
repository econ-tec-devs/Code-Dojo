// -----------------------------------------------------------------------
// <copyright file="Paging.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Paging7
{
    public class Paging
    {
        public string GetPages(int maxPages, int activePage = 0)
        {
            var result = string.Empty;
            if (maxPages > 7)
            {
                if (activePage == 2)
                {
                    return "1 (2) 3 4 5 ... 9";
                }
                return $"1 ... {activePage - 1} ({activePage}) {activePage + 1} ... {maxPages}";
            }

            for (var index = 1; index <= maxPages; index++)
            {
                if (index == activePage)
                {
                    result += $"({index}) ";
                }
                else
                {
                    result += index + " ";
                }
            }

            return result.Trim();
        }
    }
}
