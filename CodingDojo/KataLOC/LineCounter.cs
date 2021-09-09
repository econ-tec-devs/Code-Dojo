// -----------------------------------------------------------------------
// <copyright file="LineCounter.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataLOC
{
    using System;

    public class LineCounter
    {
        public int Count(string empty)
        {
            if (string.IsNullOrEmpty(empty))
            {
                return 0;
            }

            var lines = empty.Split(Environment.NewLine);

            return lines.Length;
        }
    }
}
