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
        private readonly LinesCount _lineOfCode = new LinesCount { LineOfCodeCount = 0, CommentsWhitespaceLineCount = 0 };

        public LinesCount LineOfCode(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                return _lineOfCode;
            }

            var lines = code.Split(Environment.NewLine);
            foreach (var line in lines)
            {
                if (!line.StartsWith("//") && !line.StartsWith("/*"))
                {
                    _lineOfCode.LineOfCodeCount += 1;
                }

                if (line.Contains("*/") && !line.EndsWith("*/"))
                {
                    _lineOfCode.LineOfCodeCount += 1;
                }
            }

            return _lineOfCode;
        }
    }
}
