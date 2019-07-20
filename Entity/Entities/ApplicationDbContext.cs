using Entities;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Toppping> Topping { get; set; }
        public DbSet<Size> Size { get; set; }
        public DbSet<Crust> Crust { get; set; }
        public DbSet<Sauce> Sauce { get; set; }
        public DbSet<SauceAmount> SauceAmount { get; set; }
        public DbSet<CheeseAmount> CheeseAmount { get; set; }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Payment> Payment { get; set; }

    }
}
