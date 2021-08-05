// -----------------------------------------------------------------------
// <copyright file="StringConvert.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Kata
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StringConvert
    {
        public Dictionary<string, string> ToDictionary(string input)
        {
            var result = new Dictionary<string, string>();
            var keyValues = input.Split(';');

            foreach (var keyValue in keyValues)
            {
                var splittedKeyValue = keyValue.Split('=');
                if (splittedKeyValue.First() == "" && splittedKeyValue.Last() != "")
                {
                    throw new ArgumentException();
                }

                if (input.Any())
                {
                    result.Add(splittedKeyValue.First(), splittedKeyValue.Last());
                }
            }

            return result;
        }
    }
}
