// -----------------------------------------------------------------------
// <copyright file="LineSplitter.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataBankOcr
{
    using System.Collections.Generic;
    using KataBankOcr.Interfaces;

    public class LineSplitter : ILineSplitter
    {
        public List<Entry> Split(List<Line> lines)
        {
            var entries = new List<Entry>();

            var addVar = lines.Count / 4;
            for (var i = 0; i < addVar; i++)
            {
                var entry = new Entry() { Lines = lines };
                entries.Add(entry);
            }

            return entries;
        }
    }
}
