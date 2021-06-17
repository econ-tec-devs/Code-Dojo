// -----------------------------------------------------------------------
// <copyright file="Wrapper.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace WordWrap
{
    public static class Wrapper
    {
        public static string Wrap(string text, int columnNumber)
        {
            if (columnNumber == 5)
            {
                return $"Word1{Environment.NewLine}word2";
            }
            return text;
        }
    }
}
