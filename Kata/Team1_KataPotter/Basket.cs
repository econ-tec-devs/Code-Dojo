namespace Team1_KataPotter;

public class Basket
{
    
    public decimal Checkout(List<string> books)
    {
        var price = 0m;
        
        foreach (var book in books)
        {
            price += 8.00m;
        }

        if (books.Count == 2)
        {
            price -= price * 0.05m;
        }

        return price;
    }
}