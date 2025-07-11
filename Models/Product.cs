namespace ecommerce_dotnet_backend.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } 
    public decimal Price { get; set; }
    public string Gender { get; set; } 
    public string type  { get; set; }
    public byte[] Image { get; set; }
    
}