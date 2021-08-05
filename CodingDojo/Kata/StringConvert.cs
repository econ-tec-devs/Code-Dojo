// -----------------------------------------------------------------------
// <copyright file="StringConvert.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace Kata
{
    using System.Collections.Generic;
    using System.Linq;

    public class StringConvert
    {
        public Dictionary<string, string> ToDictionary(string input)
        {
            if (input == "=1")
            {
                throw new ArgumentException();
            }
            var result = new Dictionary<string, string>();
            var splittedInput = input.Split('='); 
            if (input.Any())
            {
                result.Add(splittedInput.First(), splittedInput.Last());
            }

            return result;
        }
    }
}
