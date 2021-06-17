// -----------------------------------------------------------------------
// <copyright file="Wrapper.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace WordWrap
{
    using System;

    public static class Wrapper
    {
        public static string Wrap(string text, int columnNumber)
        {
            var wrappedText = text;
            if (columnNumber < text.Length && columnNumber != 0)
            {
                var words = text.Split(" ");
                wrappedText = string.Empty;
                foreach (var word in words)
                {
                    if (wrappedText == string.Empty)
                    {
                        wrappedText = word;
                    }
                    else
                    {
                        wrappedText += $"{Environment.NewLine}{word}";
                    }
                }
            }

            return wrappedText;
        }
    }
}
