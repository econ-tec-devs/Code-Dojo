using System;
using System.Collections.Generic;
using KataBankOcr.Interfaces;

namespace KataBankOcr
{
    public class Reader : IReader
    {
        public List<Line> Read(string filename)
        {
            throw new ArgumentNullException();
        }
    }
}