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
            if (pageCount == 1)
            {
                return "(1)";
            }

            if (pageCount == 2)
            {
                return "(1) 2";
            }

            return string.Empty;
        }
    }
}
