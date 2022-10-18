using MyHardwareWeb.Domain.Models;

namespace MyHardwareWeb.Application.Interfaces
{
    public interface IProductRepository 
    {
        Task Create(Product model);
        Task<Product> Update(Product model);
        Task<Product?> FindById(int id);
        Task<List<Product>> GetAll();
    }
}