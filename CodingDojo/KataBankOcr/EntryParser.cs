// -----------------------------------------------------------------------
// <copyright file="EntryParser.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataBankOcr
{
    using System.Collections.Generic;
    using System.Linq;
    using KataBankOcr.Interfaces;

    public class EntryParser : IEntryParser
    {
        private readonly IAccountNumberBuilder _accountNumberBuilder;
        private readonly IDigitParser _digitParser;

        public EntryParser(IDigitParser digitParser, IAccountNumberBuilder accountNumberBuilder)
        {
            _digitParser = digitParser;
            _accountNumberBuilder = accountNumberBuilder;
        }

        public List<AccountNumber> Parse(List<Entry> entries)
        {
            var accountNumbers = new List<AccountNumber>();
            foreach (var entry in entries)
            {
                var rawDigits = ParseEntry(entry);
                accountNumbers.Add(new AccountNumber());
            }

            return accountNumbers;
        }

        public List<RawDigit> ParseEntry(Entry entry)
        {
            if (entry == null)
            {
                return new List<RawDigit>();
            }

            var rawDigits = new List<RawDigit>();
            var rawDigit = new RawDigit();
            for (var i = 0; i <= 9; i++)
            {
                rawDigit.LineOne = entry.Lines.First().Text.Remove(3).Trim();
                rawDigit.LineTwo = entry.Lines[1].Text.Remove(3).Trim();
                rawDigit.LineThree = entry.Lines[2].Text.Remove(3).Trim();

                rawDigits.Add(rawDigit);
            }

            return rawDigits;
        }
    }
}
