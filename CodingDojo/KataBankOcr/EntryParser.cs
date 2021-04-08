// -----------------------------------------------------------------------
// <copyright file="EntryParser.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataBankOcr
{
    using System.Collections.Generic;
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
                accountNumbers.Add(new AccountNumber());
            }

            return accountNumbers;
        }
    }
}
