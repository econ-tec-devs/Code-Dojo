namespace KataPotter;

public class ShoppingCart
{
    public decimal Checkout(List<string> books)
    { 
       
        if (books.Any())
        {
            return 8;
        }
        return 0;
        
    }
   
}