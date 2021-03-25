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
            
            var addVar = lines.Count / 4;
            for (int i = 0; i <addVar; i++)
            {
                var entry = new Entry();
                entries.Add(entry);
            }
            return entries;
        }
    }
}