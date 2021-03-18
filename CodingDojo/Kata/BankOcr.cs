// -----------------------------------------------------------------------
// <copyright file="BankOcr.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Kata
{
    using System.Collections.Generic;

    public class BankOcr
    {
        private readonly IEntryParser entryParser;
        private readonly ILineSplitter lineSplitter;
        private readonly IReader reader;

        public BankOcr(IReader reader, ILineSplitter lineSplitter, IEntryParser entryParser)
        {
            this.reader = reader;
            this.lineSplitter = lineSplitter;
            this.entryParser = entryParser;
        }

        public List<AccountNumber> ScanFile(string fileName)
        {
            var lines = this.reader.Read(fileName);
            var entries = this.lineSplitter.Split(lines);
            return this.entryParser.Parse(entries);
        }
    }
}
