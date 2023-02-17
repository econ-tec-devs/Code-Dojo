namespace KataPotterTest;

public class ShoppingCart
{
    
    public decimal Checkout(List<string> books)
    {
        if (books == null) return 0;
        
        if (books.Any())
        {
            return 8;
        }
        
        return 0;
    }
}