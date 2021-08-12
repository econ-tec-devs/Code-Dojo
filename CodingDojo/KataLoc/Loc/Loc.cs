// -----------------------------------------------------------------------
// <copyright file="Loc.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataLOC
{
    using System;

    public class Loc
    {
        private static readonly LinesCount _LineOfCode = new LinesCount { LineOfCodeCount = 0, CommentsWhitespaceLineCount = 0 };

        public static LinesCount LineOfCode(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                return _LineOfCode;
            }

            var lines = code.Split(Environment.NewLine);
            _LineOfCode.LineOfCodeCount = lines.Length;

            return _LineOfCode;
        }
    }
}
