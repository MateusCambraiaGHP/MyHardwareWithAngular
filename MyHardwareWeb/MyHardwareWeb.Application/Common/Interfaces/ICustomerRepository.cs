using MyHardwareWeb.Domain.Models;

namespace MyHardwareWeb.Application.Interfaces
{
    public interface ICustomerRepository 
    {
        Task Create(Customer model);
        Task<Customer> Update(Customer model);
        Task<Customer?> FindById(int id);
        Task<List<Customer>> GetAll();
    }
}