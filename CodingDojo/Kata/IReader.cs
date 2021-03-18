// -----------------------------------------------------------------------
// <copyright file="IReader.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Kata
{
    using System.Collections.Generic;

    public interface IReader
    {
        List<string> Read(string fullPath);
    }
}
