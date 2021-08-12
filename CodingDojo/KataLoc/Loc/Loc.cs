// -----------------------------------------------------------------------
// <copyright file="Loc.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace KataLOC
{
    using System.Linq;

    public class Loc
    {
        public static LinesCount LineOfCode(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                return new LinesCount { LineOfCodeCount = 0, CommentsWhitespaceLineCount = 0 };
            }

            string[] lines = code.Split(Environment.NewLine);

            return new LinesCount() {LineOfCodeCount = lines.Count(), CommentsWhitespaceLineCount = 0};
        }
    }
}
