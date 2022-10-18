using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyHardware.Infrastructure.Common.Interfaces;
using MyHardwareWeb.Domain.Models;

namespace MyHardware.Infrastructure.Data
{
    public class ApplicationMySqlDbContext : DbContext, IApplicationDbContext
    {
        private IConfiguration _configuration { get; set; }

        public ApplicationMySqlDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(_configuration.GetConnectionString("DefaultConnection"),
                      ServerVersion.AutoDetect(_configuration.GetConnectionString("DefaultConnection")));
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<SupplierProductCustomer> SupplierProductCustomer { get; set; }
        public DbSet<Adress> Adress { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<SupplierProduct> SupplierProduct { get; set; }
        public DbSet<User> User { get; set; }

        public async Task<int>  Save()
        {
            return await SaveChangesAsync();
        }

        public new DbSet<TEntity> Set<TEntity>() where TEntity : Entity
        {
            return base.Set<TEntity>();
        }
    }
}
