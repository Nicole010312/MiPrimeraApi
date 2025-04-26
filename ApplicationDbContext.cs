// Data/ApplicationDbContext.cs

using Microsoft.EntityFrameworkCore;
using MiPrimeraApi.Models;

namespace MiPrimeraApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Este constructor es necesario para las herramientas de EF Core
        public ApplicationDbContext()
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}