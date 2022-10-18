using MyHardwareWeb.Domain.Models;

namespace MyHardwareWeb.Application.Interfaces
{
    public interface ISupplierProductCustomerRepository
    {
        Task<SupplierProductCustomer?> FindById(int id);
        Task<List<SupplierProductCustomer>> GetAll();
    }
}