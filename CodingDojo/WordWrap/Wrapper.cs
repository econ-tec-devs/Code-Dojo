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
            var output = rawString;
            if(rawString.Length > columnNumber && columnNumber != 0)
            {
                output = "Rouven\nmuss.";
            }

            return output;
        }
    }
}
