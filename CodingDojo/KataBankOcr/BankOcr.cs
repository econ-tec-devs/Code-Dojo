using System;
using System.Collections.Generic;
using KataBankOcr.Interfaces;

namespace KataBankOcr
{
    public class BankOcr
    {
        private readonly IReader _reader;
        private readonly ILineSplitter _lineSplitter;

        public BankOcr(IReader reader, ILineSplitter lineSplitter, IEntryParser entryParser)
        {
            if (entryParser == null) throw new ArgumentNullException(nameof(entryParser));
            _reader = reader ?? throw new ArgumentNullException(nameof(reader));
            _lineSplitter = lineSplitter ?? throw new ArgumentNullException(nameof(lineSplitter));
        }

        public List<AccountNumber> Scan(string filename)
        {
            var lines = _reader.Read(filename);
            _lineSplitter.Split(lines);
            return new List<AccountNumber>();
        }
    }
}