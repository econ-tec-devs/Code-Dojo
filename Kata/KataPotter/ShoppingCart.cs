namespace KataPotter;

public class ShoppingCart
{
    public decimal Checkout(List<string>? books)
    { 
      
        if (books != null && books.Any())
        {
            return 8;
        }
        return 0;
        
    }
   
}