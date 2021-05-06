// -----------------------------------------------------------------------
// <copyright file="Paging.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Paging7
{
    public class Paging
    {
        public string GetPaging(int pages, int currentPage)
        {
            var paging = string.Empty;
            for (int i = 1; i <= pages; i++)
            {
                if (currentPage == i)
                {
                    paging += $" ({currentPage})";
                }
                else
                {
                    paging += $" {i}";
                }
            }
            return paging.Trim();
        }
    }
}
