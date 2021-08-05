// -----------------------------------------------------------------------
// <copyright file="StringToDictionary.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataDictonary
{
    using System;
    using System.Collections.Generic;

    public class StringToDictionary
    {
        public IDictionary<string, string> ToDictionary(string input)
        {
            var dictionary = new Dictionary<string, string>();
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            if (input != string.Empty)
            {
                var keyValue = input.Split('=');
                dictionary.Add(keyValue[0], keyValue[1]);
            }

            return dictionary;
        }
    }
}
