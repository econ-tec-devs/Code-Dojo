using System.Collections.Generic;
using KataBankOcr;

namespace KataTest
{
    public class DigitParser:IDigitParser
    {
        public DigitParser(IRawDigitParser rawDigitParser)
        {

        }

        public List<RawDigit> Parse(Entry entry)
        {
            return new List<RawDigit>();
        }
    }
}