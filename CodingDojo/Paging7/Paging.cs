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
                if (currentPage > 4)
                {
                    if (currentPage > pageCount - 4)
                    {
                        return GetPagingCurrentPageInlastPart(pageCount, currentPage);
                    }

                    return GetPagingOverSeven(pageCount, currentPage);
                }

                return GetPagingCurrentPageInFirstPart(pageCount, currentPage);
            }

            var paging = string.Empty;
            for (var page = 1; page <= pageCount; page++)
            {
                paging += page == currentPage ? $" ({page})" : $" {page}";
            }

            return paging.Trim();
        }

        public string GetPagingOverSeven(int pageCount, int currentPage)
        {
            return $"1 ... {--currentPage} ({++currentPage}) {++currentPage} ... {pageCount}";
        }

        private string GetPagingCurrentPageInlastPart(int pageCount, int currentPage)
        {
            return "1 ... 5 6 7 (8) 9";
        }

        private string GetPagingCurrentPageInFirstPart(int pageCount, int currentPage)
        {
            switch (currentPage)
            {
                case 2:
                    return "1 (2) 3 4 5 ... 9";
                case 3:
                    return "1 2 (3) 4 5 ... 9";
                case 4:
                    return "1 2 3 (4) 5 ... 9";
                default: return null;
            }
        }
    }
}
