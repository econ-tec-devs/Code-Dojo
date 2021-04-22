namespace KataBankOcr.Interfaces
{
    using System.Collections.Generic;

    public interface IReader
    {
        List<Digit> Read(string filename);
    }
}
