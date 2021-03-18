using System;
using System.Collections.Generic;
using System.Linq;
using KataBankOcr.Interfaces;

namespace KataBankOcr
{
    public class Reader : IReader
    {
        public List<Line> Read(string filename)
        {
            if (filename == string.Empty) throw new ArgumentException(nameof(filename));

            throw new ArgumentNullException();
        }
    }
}