using MyHardware.ViewModel;

namespace MyHardwareWeb.Application.Interfaces
{
    public interface ISupplierProductCustomerService
    {
        Task<SupplierProductCustomerViewModel> FindById(int id);

        Task<List<SupplierProductCustomerViewModel>> GetAll();
    }
}