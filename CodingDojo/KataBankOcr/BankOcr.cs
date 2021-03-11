using System;
using System.Collections.Generic;
using KataBankOcr.Interfaces;

namespace KataBankOcr
{
    public class BankOcr
    {
        private readonly IReader _reader;
        private readonly ILineSplitter _lineSplitter;
        private readonly IEntryParser _entryParser;

        public BankOcr(IReader reader, ILineSplitter lineSplitter, IEntryParser entryParser)
        {
            _reader = reader ?? throw new ArgumentNullException(nameof(reader));
            _lineSplitter = lineSplitter ?? throw new ArgumentNullException(nameof(lineSplitter));
            _entryParser = entryParser ?? throw new ArgumentNullException(nameof(entryParser));
        }

        public List<AccountNumber> Scan(string filename)
        {
            var lines = _reader.Read(filename);
            var entries = _lineSplitter.Split(lines);
            return _entryParser.Parse(entries);
        }
    }
}