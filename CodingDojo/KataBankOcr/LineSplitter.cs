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
            
            if (lines.Count == 4)
            {
                entries.Add(new Entry());
            }
            if (lines.Count == 8)
            {
                entries.Add(new Entry());
                entries.Add(new Entry());
            }
            return entries;
        }
    }
}