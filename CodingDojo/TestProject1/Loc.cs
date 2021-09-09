using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;

namespace TestProject1
{
    public class LOC
    {
        private int _lineOfCodeCounter;

        public int GetLinesOfCode(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return 0;
            }
            var strings = text.Split(Environment.NewLine).ToList();
            foreach (var item in strings)
            {
                if (!item.StartsWith("//"))
                {
                    _lineOfCodeCounter++;
                }
            }
           
            return _lineOfCodeCounter;
        }
    }
}