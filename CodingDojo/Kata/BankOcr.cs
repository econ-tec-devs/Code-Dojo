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
        private IReader reader;

        public BankOcr(IReader reader, ILineSplitter lineSplitter, IEntryParser entryParser)
        {
            this.reader = reader;
        }

        public List<AccountNumber> ScanFile(string fileName)
        {
            this.reader.Read(fileName);
            return new List<AccountNumber>();
        }
    }
}
