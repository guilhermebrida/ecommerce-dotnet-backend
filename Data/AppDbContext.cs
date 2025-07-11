using Microsoft.EntityFrameworkCore;
using ecommerce_dotnet_backend.Models;

namespace ecommerce_dotnet_backend.Data
{
    public class AppDbContext :  DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
    
}
