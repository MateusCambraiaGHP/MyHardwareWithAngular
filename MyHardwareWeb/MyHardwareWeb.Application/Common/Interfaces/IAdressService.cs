using MyHardware.ViewModel;

namespace MyHardwareWeb.Application.Interfaces
{
    public interface IAdressService
    {
        Task Save(AdressViewModel model);
        Task<AdressViewModel> Edit(AdressViewModel model);
        AdressViewModel FindById(int id);
        Task<List<AdressViewModel>>  GetAll();
    }
}