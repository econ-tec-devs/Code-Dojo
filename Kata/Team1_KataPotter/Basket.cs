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
        if (books.Count == 3)
        {
            price -= price * 0.10m;
        }
        if (books.Count == 4)
        {
            price -= price * 0.20m;
        }

        return price;
    }
}