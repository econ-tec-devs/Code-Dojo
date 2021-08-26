namespace KataLoc
{
    using System;

    public class LinesOfCode
    {
        public int Count(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return 0;
            }

            var separator = new []{ Environment.NewLine};
            var lines = input.Split(separator, StringSplitOptions.None);
            return lines.Length;
        }

    }
}