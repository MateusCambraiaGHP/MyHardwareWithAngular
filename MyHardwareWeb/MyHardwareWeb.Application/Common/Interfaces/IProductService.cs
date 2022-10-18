using MyHardware.ViewModel;

namespace MyHardwareWeb.Application.Interfaces
{
    public interface IProductService
    {
        Task<ProductViewModel> Save(ProductViewModel model);
        Task<ProductViewModel> Edit(ProductViewModel model);
        Task<ProductViewModel> FindById(int id);
        Task<List<ProductViewModel>> GetAll();
    }
}