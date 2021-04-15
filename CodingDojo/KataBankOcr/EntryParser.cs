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
            if (entries.Any())
            {
                _digitParser.Parse(entries.First());
            }

            return entries.Select(entry => new AccountNumber()).ToList();
        }
    }
}