using Microsoft.AspNetCore.Mvc;
using static MyHardware.Utility.Constants;
using MyHardware.ViewModel;
using MyHardwareWeb.Application.Interfaces;
using MyHardware.Utils;

namespace MyHardware.Controllers
{
    [ApiController]
    [Route("api/v1.0/login/")]

    public class LoginController : Controller
    {
        private readonly IUserService _userService;
        private readonly ILogger<LoginController> _logger;

        public LoginController(IUserService userService,
            ILogger<LoginController> logger)
        {
            _userService = userService;
            _logger = logger;
        }

        [HttpPost("save")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(UserViewModel model)
        {

            await _userService.Save(model);
            TempData["success"] = "Usuário criado com sucesso.";
            return Ok(TempData);
        }

        [HttpGet("edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id)
        {
            if (id == DefaultValue.IdNullValue)
                return NotFound();
            var currentUser = await _userService.FindById(id);
            if (currentUser == null)
                return NotFound();
            return Ok(currentUser);
        }

        [HttpPost("update")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UserViewModel model)
        {
            await _userService.Edit(model);
            TempData["success"] = "Usuário alterado com sucesso.";
            return Ok(TempData);
        }

        [HttpPost("validatepassword")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ValidatePassword(UserViewModel model)
        {
            await Validate(model);
            if (!ModelState.IsValid)
            {
                var errors = ModelState.GetModelErrors();
                return BadRequest(new { errors });
            }

            TempData["success"] = "Login Efetuado com sucesso.";
            return Ok(TempData);
        }

        #region ----------Private Methods-----------
        private async Task Validate(UserViewModel model)
        {
            if (String.IsNullOrEmpty(model.Email))
            {
                ModelState.AddModelError("Email", "Preencha o e-mail.");
            }

            if (ModelState.ErrorCount == 0 && String.IsNullOrEmpty(model.Password))
            {
                ModelState.AddModelError("Password", "Preencha a Senha.");
            }

            if (ModelState.ErrorCount == 0)
            {
                var isValid = await _userService.ValidatePassword(model.Email, model.Password);
                if (!isValid)
                    ModelState.AddModelError("Password", "Email ou senha incorretos.");
            }
            return;
        }
        #endregion

        #region ------------Export------------
        //[HttpGet("export")]
        //[ValidateAntiForgeryToken]
        //public IActionResult Export()
        //{
        //    _userRepository.ExportAllUsers();
        //    return Ok();
        //}
        #endregion
    }
}