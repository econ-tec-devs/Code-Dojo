using System;
using System.Collections.Generic;
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
            return new List<AccountNumber>();
        }
    }
}