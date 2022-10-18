using Microsoft.AspNetCore.Mvc;
using MyHardware.ViewModel;
using MyHardwareWeb.Application.Interfaces;
using System.Text.Json;

namespace MyHardware.Controllers
{
    [Route("api/v1.0/cliente/")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(
            ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Route("index")]
        public async Task<IActionResult> Index()
        {
            var model = await _customerService.GetAll();
            return Ok(JsonSerializer.Serialize(model));
        }

        [HttpPost("save")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(CustomerViewModel model)
        {
            await _customerService.Save(model);
            TempData["success"] = "Cliente criado com sucesso.";
            return Ok(TempData);
        }

        [HttpGet("edit")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id)
        {
            var currentCustomer = _customerService.FindByIdAsync(id);
            if (currentCustomer is null)
                return NotFound();
            return Ok(currentCustomer);
        }

        [HttpPost("update")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(CustomerViewModel model)
        {
            await _customerService.Edit(model);
            TempData["success"] = "Cliente alterado com sucesso.";
            return Ok(TempData);
        }

        #region -------- Private Methods ----------
        private void Validate(CustomerViewModel model)
        {
            if (String.IsNullOrEmpty(model.Name))
            {
                ModelState.AddModelError("Name", "Preencha o nome.");
            }
            return;
        }
        #endregion

        #region --------------Export--------------
        //[HttpGet("export")]
        //[ValidateAntiForgeryToken]
        //public IActionResult Export()
        //{
        //    _customerService.ExportAllCustomer();
        //    return Ok();
        //}
        #endregion
    }
}