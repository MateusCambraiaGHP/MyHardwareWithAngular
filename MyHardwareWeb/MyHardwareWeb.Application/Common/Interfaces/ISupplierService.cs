using MyHardware.ViewModel;

namespace MyHardwareWeb.Application.Interfaces
{
    public interface ISupplierService
    {
        Task<SupplierViewModel> Save(SupplierViewModel model);
        Task<SupplierViewModel> Edit(SupplierViewModel model);
        Task<SupplierViewModel> FindById(int id);
        Task<List<SupplierViewModel>> GetAll();
    }
}