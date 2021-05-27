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
