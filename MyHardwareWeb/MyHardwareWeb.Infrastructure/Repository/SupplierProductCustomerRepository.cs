using MyHardware.Infrastructure.Common.Interfaces;
using MyHardwareWeb.Application.Interfaces;
using MyHardwareWeb.Domain.Models;

namespace MyHardwareWeb.Infrastructure.Repository
{
    public class SupplierProductCustomerRepository : Repository<SupplierProductCustomer>, ISupplierProductCustomerRepository
    {
        public SupplierProductCustomerRepository(IApplicationDbContext context) : base(context) { }
    }
}