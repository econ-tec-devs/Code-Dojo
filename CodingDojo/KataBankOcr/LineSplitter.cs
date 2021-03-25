using System.Collections.Generic;
using KataBankOcr.Interfaces;

namespace KataBankOcr
{
    public class LineSplitter : ILineSplitter
    {
        public List<Entry> Split(List<Line> lines)
        {
            return new List<Entry>(){new Entry()};
        }
    }
}