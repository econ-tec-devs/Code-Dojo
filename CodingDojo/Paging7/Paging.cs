// -----------------------------------------------------------------------
// <copyright file="Paging.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Paging7
{
    public class Paging
    {
        public string GetPaging(int pageCount, int currentPage)
        {
            var paging = string.Empty;
            for (int page = 1; page <= pageCount; page++)
            {
                paging += page == currentPage ? $" ({page})" : $" {page}";
            }

            return paging.Trim();
        }

        public string GetPagingOverSeven(int pageCount, int currentPage)
        {
            return "1 ... 4 (5) 6 ... 9";
        }
    }
}
