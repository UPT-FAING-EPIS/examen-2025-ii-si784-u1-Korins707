using Microsoft.EntityFrameworkCore;
using MiEcommerce.Models;

namespace MiEcommerce.Data
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}