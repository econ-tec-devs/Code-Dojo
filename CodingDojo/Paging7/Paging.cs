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
            // if (pages == 1)
            // {
            //     return "(1)";
            // }
            //
            // if (pages == 2)
            // {
            //     return "(1) 2";
            // }
            var paging = string.Empty;
            for (int i = 1; i <= pages; i++)
            {
                if (currentPage == i)
                {
                    paging += $"({currentPage})";
                }
                else
                {
                    paging += $" {i}";
                }
            }
            return paging;
        }
    }
}
