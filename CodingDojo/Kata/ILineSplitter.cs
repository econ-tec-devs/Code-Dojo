// -----------------------------------------------------------------------
// <copyright file="ILineSplitter.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Kata
{
    using System.Collections.Generic;

    public interface ILineSplitter
    {
        void Split(List<string> lines);
    }
}
