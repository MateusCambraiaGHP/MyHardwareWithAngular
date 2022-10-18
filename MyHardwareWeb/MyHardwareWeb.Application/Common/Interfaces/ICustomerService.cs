using MyHardware.ViewModel;

namespace MyHardwareWeb.Application.Interfaces
{
    public interface ICustomerService
    {
        Task<CustomerViewModel> Save(CustomerViewModel model);
        Task<CustomerViewModel> Edit(CustomerViewModel model);
        Task<CustomerViewModel> FindByIdAsync(int id);
        Task<List<CustomerViewModel>> GetAll();
    }
}