using System.Collections.Generic;
using System.Linq;
using KataBankOcr.Interfaces;

namespace KataBankOcr
{
    public class LineSplitter : ILineSplitter
    {
        public List<Entry> Split(List<Line> lines)
        {
            var entries = new List<Entry>();
            if (lines.Any())
            {
                entries.Add(new Entry());
            }
            return entries;
        }
    }
}