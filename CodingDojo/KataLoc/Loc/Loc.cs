namespace KataLOC
{
    public class Loc
    {
        public static LinesCount LineOfCode(string empty)
        {
            return new LinesCount() {LineOfCodeCount = 0, CommentsWhitespaceLineCount = 0};
        }
    }
}