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
            var keyValues = SplitInput(input);

            foreach (var keyValue in keyValues)
            {
                var keyValueParts = SplitKeyValue(keyValue);
                if (IsInvalidKeyValuePair(keyValueParts))
                {
                    throw new ArgumentException();
                }

                if (input.Any())
                {
                    result.Add(keyValueParts.First(), keyValueParts.Last());
                }
            }

            return result;
        }

        private string[] SplitInput(string input) => input.Split(new[]
            { ';' }, StringSplitOptions.RemoveEmptyEntries);

        private string[] SplitKeyValue(string keyValue) => keyValue.Split('=');

        private bool IsInvalidKeyValuePair(string[] splittedKeyValue) => splittedKeyValue.First() == "" && splittedKeyValue.Last() != "";
    }
}
