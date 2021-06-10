// -----------------------------------------------------------------------
// <copyright file="Wrapper.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace WordWrap
{
    public class Wrapper
    {
        public static string Wrap(string rawString, int columnNumber)
        {
            var output = string.Empty;
            if (rawString.Length > columnNumber && columnNumber != 0)
            {
                var line = string.Empty;
                var words = rawString.Split(" ");
                foreach (var word in words)
                {
                    if (word.Length + line.Length > columnNumber)
                    {
                        output += $"\n{word}";
                        line = word;
                    }
                    else
                    {
                        output += $" {word}";
                        line += $" {word}";
                    }
                }
            }
            else
            {
                output = rawString;
            }

            return output.Trim();
        }
    }
}
