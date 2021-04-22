using System.Collections.Generic;

namespace KataBankOcr.Interfaces
{
    public interface IEntryParser
    {
        List<AccountNumber> Parse(List<Entry> entries);
        AccountNumber Parse(Entry entries);
    }
}