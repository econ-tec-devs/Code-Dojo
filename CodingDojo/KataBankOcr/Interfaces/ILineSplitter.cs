using System.Collections.Generic;

namespace KataBankOcr.Interfaces
{
    public interface ILineSplitter
    {
        List<Entry> Split(List<Line> lines);
    }
}