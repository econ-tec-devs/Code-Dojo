// -----------------------------------------------------------------------
// <copyright file="Paging.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Paging7
{
    public class Paging
    {
        public string ShowPaging(int currentPage, int maxPage)
        {
            var result = string.Empty;
           
            for (int i = 1; i <= maxPage; i++)
            {
                if (i== currentPage)
                {
                    result += $" ({i})";
                }
                else
                {
                    result += $" {i}";
                }
            }

            return result.Trim();
        }
    }
}
