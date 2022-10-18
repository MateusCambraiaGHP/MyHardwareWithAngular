using MyHardwareWeb.Domain.Models;

namespace MyHardwareWeb.Application.Interfaces
{
    public interface IAdressRepository
    {
        Task Create(Adress model);
        Task<Adress> Update(Adress model);
        Task<Adress?> FindById(int id);
        Task<List<Adress>> GetAll();
    }
}