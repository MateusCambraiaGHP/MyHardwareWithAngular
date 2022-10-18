using MyHardwareWeb.Domain.Models;

namespace MyHardwareWeb.Application.Interfaces
{
    public interface ISupplierProductRepository
    {
        Task Create(SupplierProduct model);
        Task<SupplierProduct> Update(SupplierProduct model);
        Task<SupplierProduct?> FindById(int id);
        Task<List<SupplierProduct>> GetAll();
    }
}