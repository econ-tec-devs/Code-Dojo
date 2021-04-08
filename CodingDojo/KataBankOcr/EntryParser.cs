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
            var accountNumbers = new List<AccountNumber>();
            if (entries.Any())
            {
                accountNumbers.Add(new AccountNumber());
            }

            return accountNumbers;
        }
    }
}