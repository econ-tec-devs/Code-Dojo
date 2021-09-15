// -----------------------------------------------------------------------
// <copyright file="LineCounter.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;

namespace KataLOC
{
    using System;
    using System.Linq;

    public class LineCounter
    {
        public int Count(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                return 0;
            }

            code = RemoveWhitespace(code);

            var lines = code.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                lines = RemoveLineComment(line, lines).ToArray();
            }

            foreach (var line in lines)
            {
                if (line.StartsWith("/*") && line.EndsWith("*/"))
                {
                    lines = RemoveBlockComment(line, lines).ToArray();
                }
            }

            return lines.Length;
        }

        private static string RemoveWhitespace(string code)
        {
            code = code.Replace(" ", "");
            return code;
        }

        private IEnumerable<string> RemoveBlockComment(string line, string[] lines)
        {
            return IsBlockComment(line) ? lines.Except(new[] {line}) : lines;
        }

        private IEnumerable<string> RemoveLineComment(string line, string[] lines)
        {
            return IsLineComment(line) ? lines.Except(new[] {line}) : lines;
        }

        private bool IsBlockComment(string line)
            => line.StartsWith("/*") && line.EndsWith("*/");

        private bool IsLineComment(string line) 
            => line.StartsWith("//");
    }
}