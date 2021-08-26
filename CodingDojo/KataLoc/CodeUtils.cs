// -----------------------------------------------------------------------
// <copyright file="CodeUtils.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataLoc
{
    using System.Linq;

    public class CodeUtils
    {
        public LineCount Loc(string input) => string.IsNullOrWhiteSpace(input) ? new LineCount() : CountLines(input);

        private LineCount CountLines(string input)
        {
            var lines = input.Split("\n");
            var loc = lines.Count(IsLineOfCode);
            return new LineCount
            {
                Loc = loc,
                Comments = lines.Length - loc
            };
        }

        private bool IsLineOfCode(string line)
        {
            return string.IsNullOrWhiteSpace(line) == false 
                   && line.StartsWith("//") == false
                   && line.StartsWith("/*") == false;
        }
    }
}
