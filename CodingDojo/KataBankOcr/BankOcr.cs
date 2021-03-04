using System.Collections.Generic;
using KataBankOcr.Interfaces;

namespace KataBankOcr
{
    public class BankOcr
    {
        public BankOcr()
        {
            
        }

        public BankOcr(IReader reader)
        {
        }

        public List<AccountNumber> Scan(string filename)
        {
            return new List<AccountNumber>();
        }
    }
}