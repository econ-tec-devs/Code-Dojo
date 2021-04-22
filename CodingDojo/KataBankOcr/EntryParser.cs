using System;
using System.Collections.Generic;
using System.Linq;
using KataBankOcr;
using KataBankOcr.Interfaces;

namespace KataTest
{
    public class EntryParser : IEntryParser
    {
        private readonly IDigitParser _digitParser;

        public EntryParser(IDigitParser digitParser)
        {
            _digitParser = digitParser;
        }

        public List<AccountNumber> Parse(List<Entry> entries)
        {
            return entries.Select(Parse).ToList();
        }

        public AccountNumber Parse(Entry entry)
        {
            _digitParser.Parse(entry);
            return new AccountNumber();
        }
    }
}