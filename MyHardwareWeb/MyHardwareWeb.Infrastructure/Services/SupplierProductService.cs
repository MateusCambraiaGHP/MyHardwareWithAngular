using AutoMapper;
using MyHardware.ViewModel;
using MyHardwareWeb.Application.Interfaces;
using MyHardwareWeb.Domain.Models;

namespace MyHardwareWeb.Infrastructure.Services
{
    public class SupplierProductService : ISupplierProductService
    {
        private readonly ISupplierProductRepository _supplierProductRepository;
        private readonly IMapper _mapper;

        public SupplierProductService(ISupplierProductRepository supplierProductRepository,
            IMapper mapper)
        {
            _mapper = mapper;
            _supplierProductRepository = supplierProductRepository;
        }

        public async Task<SupplierProductViewModel> FindById(int id)
        {
            var currentSupplierProduct = await _supplierProductRepository.FindById(id) ?? new SupplierProduct();
            var SupplierProductMap     = _mapper.Map<SupplierProduct, SupplierProductViewModel>(currentSupplierProduct);
            return SupplierProductMap;
        }

        public async Task<List<SupplierProductViewModel>> GetAll()
        {
            var listSupplierProduct    = await _supplierProductRepository.GetAll() ?? new List<SupplierProduct>();
            var listSupplierProductMap = _mapper.Map<List<SupplierProductViewModel>>(listSupplierProduct);
            return listSupplierProductMap;
        }
    }
}