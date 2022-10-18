using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;
using MimeKit.Text;
using MyHardware.ViewModel;
using MyHardwareWeb.Application.Interfaces;

namespace MyHardwareWeb.Infrastructure.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _config;

        public EmailService(
            IConfiguration config)
        {
            _config = config;
        }

        public async Task<bool> SendEmail(EmailViewModel model)
        {
            try
            {
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse(_config.GetSection("EmailUsername").Value));
                email.To.Add(MailboxAddress.Parse(model.To));
                email.Subject = model.Subject;
                email.Body = new TextPart(TextFormat.Html) { Text = model.Body };

                using var smtp = new SmtpClient();
                await smtp.ConnectAsync(_config.GetSection("EmailHost").Value, 587, SecureSocketOptions.StartTls);
                await smtp.AuthenticateAsync(_config.GetSection("EmailUsername").Value, _config.GetSection("EmailPassword").Value);
                await smtp.SendAsync(email);
                await smtp.DisconnectAsync(true);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}