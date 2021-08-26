// -----------------------------------------------------------------------
// <copyright file="LineCounter.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Linq;

namespace KataLoc
{
    public class LineCounter
    {
        public int CountCodeLines(string lines)
        {
            if (lines.StartsWith("//"))
            {
                return 0;
            }

            if (lines.Any())
            {
                return 1;
            }

            return 0;
        }
    }
}
