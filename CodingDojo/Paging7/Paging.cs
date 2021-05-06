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
            if (pages == 1)
            {
                return "(1)";
            }

            if (pages == 2)
            {
                return "(1) 2";
            }

            return string.Empty;
        }
    }
}
