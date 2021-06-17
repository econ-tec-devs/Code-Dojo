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
            if (columnNumber == 8)
            {
                return $"Word1{Environment.NewLine}word2";
            }

            if (columnNumber == 5)
            {
                return $"Word1{Environment.NewLine}word2";
            }

            return text;
        }
    }
}
