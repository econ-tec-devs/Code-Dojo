// -----------------------------------------------------------------------
// <copyright file="LineSplitter.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.Linq;

namespace KataBankOcr
{
    using System.Collections.Generic;
    using KataBankOcr.Interfaces;

    public class LineSplitter : ILineSplitter
    {
        private int LinesPerEntry = 4;

        public List<Entry> Split(List<Digit> lines)
        {
            var entries = new List<Entry>();

            var entryCount = lines.Count / LinesPerEntry;
            for (var currentEntry = 0; currentEntry < entryCount; currentEntry++)
            {
                entries.Add(new Entry { Lines = lines.Skip(currentEntry*LinesPerEntry).Take(LinesPerEntry).ToList() });
            }

            return entries;
        }
    }
}
