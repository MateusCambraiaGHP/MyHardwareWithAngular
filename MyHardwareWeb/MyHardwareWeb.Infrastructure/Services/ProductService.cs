using AutoMapper;
using MyHardware.ViewModel;
using MyHardwareWeb.Application.Interfaces;
using MyHardwareWeb.Domain.Models;

namespace MyHardwareWeb.Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository,
            IMapper mapper)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task<ProductViewModel> Save(ProductViewModel model)
        {
            var productMap = _mapper.Map<ProductViewModel, Product>(model);
            await _productRepository.Create(productMap);
            return model;
        }

        public async Task<ProductViewModel> Edit(ProductViewModel model)
        {
            var productMap = _mapper.Map<ProductViewModel, Product>(model);
            await _productRepository.Update(productMap);
            return model;
        }

        public async Task<ProductViewModel> FindById(int id)
        {
            var currentProduct = await _productRepository.FindById(id) ?? new Product();
            var productMap     = _mapper.Map<Product, ProductViewModel>(currentProduct);
            return productMap;
        }

        public async Task<List<ProductViewModel>> GetAll()
        {
            var listProduct    = await _productRepository.GetAll() ?? new List<Product>();
            var listProductMap = _mapper.Map<List<ProductViewModel>>(listProduct);
            return listProductMap;
        }
    }
}