// -----------------------------------------------------------------------
// <copyright file="LineCounter.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.Linq;

namespace KataLOC
{
    using System;

    public class LineCounter
    {

        public int Count(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                return 0;
            }

            var lines = code.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            return lines.Count(line => !line.StartsWith("//"));
        }
    }
}
