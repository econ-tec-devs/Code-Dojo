// -----------------------------------------------------------------------
// <copyright file="LineCounter.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataLoc
{
    using System.Linq;

    public class LineCounter
    {
        public int CountCodeLines(string lines)
        {
            if (lines.StartsWith("/*"))
            {
                return 0;
            }

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
