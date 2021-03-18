// -----------------------------------------------------------------------
// <copyright file="Reader.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataTest
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Kata;

    public class Reader : IReader
    {
        public List<string> Read(string fullPath)
        {
            return File.ReadAllLines(fullPath).ToList();
        }
    }
}
