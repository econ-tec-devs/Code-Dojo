// -----------------------------------------------------------------------
// <copyright file="LineCounter.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace KataLoc
{
    public class LineCounter
    {
        public int CountCodeLines(string lines)
        {
            if (lines != string.Empty)
            {
                return 1;
            }
            return 0;
        }
    }
}
