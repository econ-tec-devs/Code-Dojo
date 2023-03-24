namespace Team1_KataPotter;

public class Basket
{
    
    public decimal Checkout(List<string> books)
    {
        var price = 0m;
        decimal[] discount = { 0m, 1m, 0.95m, 0.9m, 0.8m };
        var count = 0;
        
        foreach (var book in books)
        {
            price += 8.00m;
            count++;
        }
        
        return price * discount[count];
        
    }
}