namespace Team1_KataPotter;

public class Basket
{
    public decimal Checkout(List<string> books)
    {
        var price = 0m;
        decimal[] discount = { 0m, 1m, 0.95m, 0.9m, 0.8m, 0.75m };
        var count = 0;
   
        var distinctBooks = books.Distinct();

        price = distinctBooks.Count() * 8 * discount[distinctBooks.Count()];

        foreach (var book in distinctBooks)
        {
            books.Remove(book);
        }
        
        foreach (var book in books)
        {
            price += 8.00m;
        }

        return price;
    }
}