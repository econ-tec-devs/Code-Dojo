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
            if (reader == null) throw new ArgumentNullException(nameof(reader));
            if (lineSplitter == null) throw new ArgumentNullException(nameof(lineSplitter));
            if (entryParser == null) throw new ArgumentNullException(nameof(entryParser));
            _reader = reader;
        }

        public List<AccountNumber> Scan(string filename)
        {
            _reader.Read(filename);
            return new List<AccountNumber>();
        }
    }
}