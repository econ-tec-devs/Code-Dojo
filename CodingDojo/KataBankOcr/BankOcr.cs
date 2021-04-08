// -----------------------------------------------------------------------
// <copyright file="BankOcr.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataBankOcr
{
    using System;
    using System.Collections.Generic;
    using KataBankOcr.Interfaces;

    public class BankOcr
    {
        private readonly IEntryParser _entryParser;
        private readonly ILineSplitter _lineSplitter;
        private readonly IReader _reader;

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
