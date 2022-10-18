using Microsoft.EntityFrameworkCore;
using MyHardwareWeb.Domain.Models;

namespace MyHardware.Infrastructure.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<SupplierProductCustomer> SupplierProductCustomer { get; set; }
        public DbSet<Adress> Adress { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<SupplierProduct> SupplierProduct { get; set; }
        public DbSet<User> User { get; set; }
        public Task<int> Save();
        DbSet<TEntity> Set<TEntity>() where TEntity : Entity;
    }
}