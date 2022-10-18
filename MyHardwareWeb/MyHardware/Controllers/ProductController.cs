using Microsoft.AspNetCore.Mvc;
using static MyHardware.Utility.Constants;
using MyHardware.ViewModel;
using MyHardwareWeb.Application.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyHardware.Controllers
{
    [Route("api/v1.0/produto/")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("index")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index()
        {
            var model = await _productService.GetAll();
            return Ok(model);
        }

        [HttpGet("create")]
        [ValidateAntiForgeryToken]
        public IActionResult Create()
        {
            ViewBag.ProductType = new SelectList(ProductType.GetComboboxList(), "Value", "Text");
            return Ok(ViewBag.ProductType);
        }

        [HttpPost("save")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(ProductViewModel model)
        {
            await _productService.Save(model);
            TempData["success"] = "Produto criado com sucesso.";
            return Ok(TempData);
        }

        [HttpGet("edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id)
        {
            if (id == DefaultValue.IdNullValue)
                return NotFound();
            var currentProduct = await _productService.FindById(id);
            if (currentProduct is null)
                return NotFound();
            return View(currentProduct);
        }

        [HttpPost("update")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductViewModel model)
        {
            await _productService.Edit(model);
            TempData["success"] = "Produto alterado com sucesso.";
            return Ok(TempData);
        }

        #region -------- Private Methods ----------
        private void Validate(ProductViewModel model)
        {
            if (String.IsNullOrEmpty(model.Name))
            {
                ModelState.AddModelError("Name", "Preencha o nome.");
            }
            return;
        }
        #endregion

        #region -----------------Export---------------------
        //[HttpGet("export")]
        //[ValidateAntiForgeryToken]
        //public IActionResult Export()
        //{
        //    _productRepository.ExportAllProducts();
        //    return Ok();
        //}
        #endregion
    }
}