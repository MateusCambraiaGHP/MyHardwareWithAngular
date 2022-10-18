using MyHardwareWeb.Domain.Models;

namespace MyHardwareWeb.Application.Interfaces
{
    public interface IUserRepository
    {
        Task Create(User model);
        Task<User> Update(User model);
        Task<User?> FindById(int id);
        Task<List<User>> GetAll();
        Task<User> GetUserByEmailAndPassWord(string email, string password);
    }
}