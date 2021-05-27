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
            if (pageCount > 7)
            {
                return GetPagingOverSeven(pageCount, currentPage);
            }
            for (int page = 1; page <= pageCount; page++)
            {
                //if (pageCount > 7)
                //{
                    paging += page == currentPage ? $" ({page})" : $" {page}";
                //}
                
            }

            return paging.Trim();
        }

        public string GetPagingOverSeven(int pageCount, int currentPage)
        {
            var result = string.Empty;

            if (pageCount <= 9)
            {
                result = "1 ... 4 (5) 6 ... 9";
            }
            else
            {
                result = "1 ... 41 (42) 43 ... 100";
            }

            return result;
        }
    }
}
