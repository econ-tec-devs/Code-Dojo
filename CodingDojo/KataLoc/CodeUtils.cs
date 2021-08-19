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

        private static int CountLines(string input)
        {
            return input.Split("\n").Count(line => !string.IsNullOrWhiteSpace(line));
        }
    }
}
