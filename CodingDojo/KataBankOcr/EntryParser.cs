using System.Collections.Generic;
using KataBankOcr.Interfaces;

namespace KataBankOcr
{
    public class EntryParser : IEntryParser
    {
        private readonly IDigitParser _digitParser;
        private readonly IAccountNumberBuilder _accountNumberBuilder;

        public EntryParser(IDigitParser digitParser, IAccountNumberBuilder accountNumberBuilder)
        {
            _digitParser = digitParser;
            _accountNumberBuilder = accountNumberBuilder;
        }

        public List<AccountNumber> Parse(List<Entry> entries)
        {
            throw new System.NotImplementedException();
        }
    }
}