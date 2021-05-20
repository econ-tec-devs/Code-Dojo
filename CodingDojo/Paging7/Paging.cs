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
            string paging = string.Empty;
            for (int i = 1; i <= pageCount; i++)
            {
                if (i == currentPage)
                {
                    paging += $" ({i})";
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
