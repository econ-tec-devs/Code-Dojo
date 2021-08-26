// -----------------------------------------------------------------------
// <copyright file="CodeUtils.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataLoc
{
    using System.Linq;

    public class CodeUtils
    {
        private bool _openMultiLineComment = false;
        
        public LineCount Loc(string input) => string.IsNullOrWhiteSpace(input) ? new LineCount() : CountLines(input);

        private LineCount CountLines(string input)
        {
            var lines = input.Split("\n");
            var loc = lines.Count(IsLineOfCode);
            return new LineCount
            {
                Loc = loc,
                Comments = lines.Length - loc
            };
        }

        private bool IsLineOfCode(string line)
        {
            return string.IsNullOrWhiteSpace(line) == false 
                   && line.StartsWith("//") == false
                   && HandleMultiLineComment(line) == false
                   && _openMultiLineComment == false;
        }

        private bool HandleMultiLineComment(string line)
        {
            if (line.StartsWith("/*") && line.EndsWith("*/"))
            {
                return true;
            }
            
            if (line.StartsWith("/*"))
            {
                _openMultiLineComment = true;
                return true;
            }

            if (line.EndsWith("*/"))
            {
                _openMultiLineComment = false;
                return true;
            }
            
            return false;
        }
    }
}
