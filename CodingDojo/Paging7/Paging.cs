// -----------------------------------------------------------------------
// <copyright file="Paging.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Paging7
{
    public class Paging
    {
        public string GetPages(int maxPages)
        {
            var result = string.Empty;

            for (var currentPage = 1; currentPage <= maxPages; currentPage++)
            {
                result += currentPage + " ";
            }

            return result.Trim();
        }
    }
}
