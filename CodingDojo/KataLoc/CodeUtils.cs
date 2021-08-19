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
        public int Loc(string input) => string.IsNullOrWhiteSpace(input) ? 0 : CountLines(input);

        private int CountLines(string input)
        {
            return input.Split("\n").Count(line => IsLineOfCode(line));
        }

        private bool IsLineOfCode(string line)
        {
            return !string.IsNullOrWhiteSpace(line) && !line.StartsWith("//");
        }
    }
}
