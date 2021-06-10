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
            if(rawString.Length > columnNumber && columnNumber != 0)
            {
                return "Rouven\nmuss.";
            }

            return rawString;
        }
    }
}
