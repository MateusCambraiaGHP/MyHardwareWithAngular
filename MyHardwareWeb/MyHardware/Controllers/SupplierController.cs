using Microsoft.AspNetCore.Mvc;
using static MyHardware.Utility.Constants;
using MyHardware.ViewModel;
using MyHardwareWeb.Application.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyHardware.Controllers
{
    [Route("api/v1.0/fornecedor/")]
    [ApiController]
    public class SupplierController : Controller
    {
        private readonly ISupplierService _supplierService;

        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _supplierService.GetAll();
            return Ok(model);
        }

        public IActionResult Create()
        {
            ViewBag.ProductType = new SelectList(ProductType.GetComboboxList(), "Value", "Text");
            return View(ViewBag.ProductType);
        }

        [HttpPost("save")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(SupplierViewModel model)
        {
            await _supplierService.Save(model);
            TempData["success"] = "Fornecedor criado com sucesso.";
            return Ok(TempData);
        }

        public IActionResult Edit(int id)
        {
            if (id == DefaultValue.IdNullValue)
            {
                return NotFound();
            }
            var currentSupplier = _supplierService.FindById(id);
            if (currentSupplier == null)
            {
                return NotFound();
            }
            return View(currentSupplier);
        }

        [HttpPost("edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SupplierViewModel model)
        {
            await _supplierService.Edit(model);
            TempData["success"] = "Fornecedor alterado com sucesso.";
            return Ok(TempData);
        }

        [HttpGet("getinvitedialog")]
        [ValidateAntiForgeryToken]
        public IActionResult GetInviteDialog()
        {
            return PartialView("_InviteCustomerPartial");
        }

        #region -------- Private Methods ----------
        private void Validate(SupplierViewModel model)
        {
            if (String.IsNullOrEmpty(model.Name))
            {
                ModelState.AddModelError("Name", "Preencha o nome.");
            }
            return;
        }
        #endregion

        #region ----------------Export--------------------
        //[HttpGet("export")]
        //[ValidateAntiForgeryToken]
        //public IActionResult Export()
        //{
        //    _supplierRepository.ExportAllSupplier();
        //    return Ok();
        //}
        #endregion
    }
}