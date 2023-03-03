namespace Team1_KataPotter;

public class Basket
{
    public decimal Checkout(List<string> books)
    {
        if (books.Any())
        {
            return 8.00m;
        }
        return 0;
    }
}