using System;
using System.Collections.Generic;
using KataBankOcr.Interfaces;

namespace KataBankOcr
{
    public class BankOcr
    {
        private readonly IReader _reader;

        public BankOcr(IReader reader, ILineSplitter lineSplitter, IEntryParser entryParser)
        {
            if (lineSplitter == null) throw new ArgumentNullException(nameof(lineSplitter));
            if (entryParser == null) throw new ArgumentNullException(nameof(entryParser));
            _reader = reader ?? throw new ArgumentNullException(nameof(reader));
        }

        public List<AccountNumber> Scan(string filename)
        {
            _reader.Read(filename);
            return new List<AccountNumber>();
        }
    }
}