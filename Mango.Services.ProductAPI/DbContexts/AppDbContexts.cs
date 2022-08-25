using Mango.Services.ProductAPI.Model.Dto;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ProductAPI.DbContexts
{
    public class AppDbContexts : DbContext
    {
        public AppDbContexts(DbContextOptions<AppDbContexts> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

    }
}
