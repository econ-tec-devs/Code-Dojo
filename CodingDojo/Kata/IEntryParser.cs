// -----------------------------------------------------------------------
// <copyright file="IEntryParser.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;

namespace Kata
{
    public interface IEntryParser
    {
        void Parse(List<Entry> entries);
    }
}
