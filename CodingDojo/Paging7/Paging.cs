// -----------------------------------------------------------------------
// <copyright file="Paging.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Paging7
{
    public class Paging
    {
        public string GetPages(int maxPages)
        {
            if (maxPages == 1)
            {
                return "1";
            }
            return string.Empty;
        }
    }
}
