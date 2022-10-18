using Microsoft.AspNetCore.Mvc;
using MyHardware.Utils;
using MyHardware.ViewModel;
using MyHardwareWeb.Application.Interfaces;

namespace MyHardware.Controllers
{
    [Route("api/v1.0/email/")]
    [ApiController]
    public class EmailController : Controller
    {
        private readonly IEmailService _emailService;

        public EmailController(
            IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost("sendemail")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendEmail(EmailViewModel model)
        {
            Validate(model);
            if (!ModelState.IsValid)
            {
                var errors = ModelState.GetModelErrors();
                return BadRequest(new { errors });
            }

            bool emailSent = await _emailService.SendEmail(model);
            if (!emailSent)
                return BadRequest();
            return Ok();
        }

        #region -------- Private Methods ----------
        private void Validate(EmailViewModel model)
        {
            if (String.IsNullOrEmpty(model.To))
            {
                ModelState.AddModelError("To", "Preencha o e-mail.");
            }

            if (String.IsNullOrEmpty(model.Token))
            {
                ModelState.AddModelError("Token", "Por favor preencha o token.");
            }

            if (String.IsNullOrEmpty(model.NameClient))
            {
                ModelState.AddModelError("NameClient", "Por favor preencha o nome do cliente.");
            }
            return;
        }
        #endregion
    }
}