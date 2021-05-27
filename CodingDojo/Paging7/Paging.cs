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
            if (MoreThan7Pages(maxPages))
            {
                return GetPaginationForMoreThanSeven(maxPages, activePage);
            }

            result += PagesFromOneToPageNumber(activePage, maxPages,1);

            return result.Trim();
        }

        private static string GetPaginationForMoreThanSeven(int maxPages, int activePage)
        {
            var result = string.Empty;

            if (IsInFirstPart(activePage))
            {
                result += PagesFromOneToPageNumber(activePage, 5,1);

                result += $"... {maxPages}";
                return result;
            }

            if (IsInLastPart(activePage) && activePage > 5)
            {
                result = "1 ... ";
                result += PagesFromOneToPageNumber(activePage,8,5);
                result += $"{maxPages}";
                return result;
            }

            return $"1 ... {activePage - 1} ({activePage}) {activePage + 1} ... {maxPages}";

        }

        private static string PagesFromOneToPageNumber(int activePage, int pageNumber, int from)
        {
            var result = string.Empty;
            for (var index = from; index <= pageNumber; index++)
            {
                result += GetFormattedPage(activePage, index);
            }

            return result;
        }

        private static string GetFormattedPage(int activePage, int index)
        {
            return index == activePage ? $"({index}) " : $"{index} ";
        }

        private static bool MoreThan7Pages(int maxPages) => maxPages > 7;

        private static bool IsInFirstPart(int activePage) => activePage <= 4;

        private static bool IsInLastPart(int activePage) => activePage <= 8;
    }
}
