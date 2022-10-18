using MyHardware.Infrastructure.Common.Interfaces;
using MyHardwareWeb.Application.Interfaces;
using MyHardwareWeb.Domain.Models;

namespace MyHardwareWeb.Infrastructure.Repository
{
    public class SupplierProductRepository : Repository<SupplierProduct>, ISupplierProductRepository
    {
        public SupplierProductRepository(IApplicationDbContext context) : base(context) { }
    }
}