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
        private readonly ILineSplitter lineSplitter;
        private IReader reader;

        public BankOcr(IReader reader, ILineSplitter lineSplitter, IEntryParser entryParser)
        {
            this.reader = reader;
            this.lineSplitter = lineSplitter;
        }

        public List<AccountNumber> ScanFile(string fileName)
        {
            var lines = this.reader.Read(fileName);
            this.lineSplitter.Split(lines);
            return new List<AccountNumber>();
        }
    }
}
