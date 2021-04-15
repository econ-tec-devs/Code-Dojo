using System.Collections.Generic;
using KataBankOcr;

namespace KataTest
{
    public interface IDigitParser
    {
        List<RawDigit> Parse(Entry entry);
    }
}