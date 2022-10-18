using MyHardware.ViewModel;

namespace MyHardwareWeb.Application.Interfaces
{
    public interface ISupplierProductService
    {
        Task<SupplierProductViewModel> FindById(int id);
        Task<List<SupplierProductViewModel>>  GetAll();
    }
}