namespace Paging7
{
    public class Paging
    {
        public string GetPaging(int pageCount, int currentPage)
        {
            if (currentPage==1)
            {
                return "(1)";
            }

            return string.Empty;

        }
    }
}