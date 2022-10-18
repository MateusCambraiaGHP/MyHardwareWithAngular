using MyHardware.ViewModel;

namespace MyHardwareWeb.Application.Interfaces
{
    public interface IEmailService
    {
        Task<bool> SendEmail(EmailViewModel model);
    }
}