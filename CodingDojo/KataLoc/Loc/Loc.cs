// -----------------------------------------------------------------------
// <copyright file="Loc.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataLOC
{
    using System.Linq;

    public class Loc
    {
        public static LinesCount LineOfCode(string code)
        {
            if (code.Any())
            {
                return new LinesCount { LineOfCodeCount = 1, CommentsWhitespaceLineCount = 0 };
            }

            return new LinesCount { LineOfCodeCount = 0, CommentsWhitespaceLineCount = 0 };
        }
    }
}
