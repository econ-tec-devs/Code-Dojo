using System;
using System.Collections.Generic;
using KataBankOcr.Interfaces;

namespace KataBankOcr
{
    public class BankOcr
    {
        public BankOcr(IReader reader, ILineSplitter lineSplitter, IEntryParser entryParser)
        {
            if (reader == null) throw new ArgumentNullException(nameof(reader));
            if (lineSplitter == null) throw new ArgumentNullException(nameof(lineSplitter));
            if (entryParser == null) throw new ArgumentNullException(nameof(entryParser));
        }

        public List<AccountNumber> Scan(string filename)
        {
            return new List<AccountNumber>();
        }
    }
}