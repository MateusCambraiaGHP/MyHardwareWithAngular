using MyHardware.ViewModel;

namespace MyHardwareWeb.Application.Interfaces
{
    public interface IUserService
    {
        Task<UserViewModel> Save(UserViewModel model); 
        Task<UserViewModel> Edit(UserViewModel model);
        Task<UserViewModel> FindById(int id);
        Task<List<UserViewModel>> GetAll();
        Task<bool> ValidatePassword(string email, string password);
    }
}