using System;
using System.Collections.Generic;
using System.Linq;
using KataBankOcr;
using KataBankOcr.Interfaces;

namespace KataTest
{
    public class EntryParser : IEntryParser
    {
        public EntryParser(IDigitParser digitParser)
        {
            
        }

        public List<AccountNumber> Parse(List<Entry> entries)
        {
            return entries.Select(entry => new AccountNumber()).ToList();
        }

        public AccountNumber Parse(Entry entry)
        {
            return new AccountNumber();
        }
    }
}