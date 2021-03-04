using System.Collections.Generic;
using KataBankOcr.Interfaces;

namespace KataBankOcr
{
    public class BankOcr
    {
        public BankOcr(IReader reader, ILineSplitter lineSplitter, IEntryParser entryParser)
        {
        }

        public List<AccountNumber> Scan(string filename)
        {
            return new List<AccountNumber>();
        }
    }
}