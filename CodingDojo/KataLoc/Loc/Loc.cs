// -----------------------------------------------------------------------
// <copyright file="Loc.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataLOC
{
    using System;
    using System.Text.RegularExpressions;

    public class Loc
    {
        private const string _CommentMatch = "(//.*)";
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
                var m = Regex.Matches(line, _CommentMatch);
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
