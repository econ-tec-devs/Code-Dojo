namespace KataBankOcr.Interfaces
{
    using System.Collections.Generic;

    public interface IReader
    {
        List<Line> Read(string filename);
    }
}
