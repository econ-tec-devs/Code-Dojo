using System.Collections.Generic;
using KataBankOcr.Interfaces;

namespace KataBankOcr
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
            throw new System.NotImplementedException();
        }
    }
}