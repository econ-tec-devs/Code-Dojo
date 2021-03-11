using System.Collections.Generic;

namespace KataBankOcr.Interfaces
{
    public interface ILineSplitter
    {
        void Split(List<Line> lines);
    }
}