using Microsoft.EntityFrameworkCore;

namespace sanJuanBeers.Models
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) { }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Beer> Beers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetail> SaleDetails { get; set; }
        public DbSet<Ingress> Ingresss { get; set; }
        public DbSet<IngressDetail> IngressDetails { get; set; }

    }
}
