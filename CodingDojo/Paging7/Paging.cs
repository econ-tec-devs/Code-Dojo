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
            if (pageCount > 7)
            {
                return currentPage > 4
                    ? GetPagingOverSeven(pageCount, currentPage)
                    : GetPagingCurrentPageInFirstPart(pageCount, currentPage);
            }

            var paging = string.Empty;
            for (var page = 1; page <= pageCount; page++)
            {
                paging += page == currentPage ? $" ({page})" : $" {page}";
            }

            return paging.Trim();
        }

        private string GetPagingCurrentPageInFirstPart(int pageCount, int currentPage)
        {
            if (currentPage == 2)
            {
                return "1 (2) 3 4 5 ... 9";
            }
            else
            {
                return "1 2 3 (4) 5 ... 9";
            }

        }

        public string GetPagingOverSeven(int pageCount, int currentPage)
        {
            return $"1 ... {--currentPage} ({++currentPage}) {++currentPage} ... {pageCount}";
        }
    }
}
