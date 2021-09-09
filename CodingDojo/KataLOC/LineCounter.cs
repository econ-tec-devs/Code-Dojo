using System;

namespace KataLOC
{
    public class LineCounter
    {
        public LineCounter()
        {
        }

        public int Count(string empty)
        {
            if (string.IsNullOrEmpty(empty))
            {
                return 0;
            }
            return 1;
        }
    }
}