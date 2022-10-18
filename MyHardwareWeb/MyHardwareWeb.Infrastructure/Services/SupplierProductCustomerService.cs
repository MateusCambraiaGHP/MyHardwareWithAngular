using AutoMapper;
using MyHardware.ViewModel;
using MyHardwareWeb.Application.Interfaces;
using MyHardwareWeb.Domain.Models;

namespace MyHardwareWeb.Infrastructure.Services
{
    public class SupplierProductCustomerService : ISupplierProductCustomerService
    {
        private readonly ISupplierProductCustomerRepository _supplierProductCustomerRepository;
        private readonly IMapper _mapper;

        public SupplierProductCustomerService(ISupplierProductCustomerRepository supplierProductCustomerRepository,
            IMapper mapper)
        {
            _mapper = mapper;
            _supplierProductCustomerRepository = supplierProductCustomerRepository;
        }

        public async Task<SupplierProductCustomerViewModel> FindById(int id)
        {
            var currentSupplierProductCustomer = await _supplierProductCustomerRepository.FindById(id) ?? new SupplierProductCustomer();
            var supplierProductCustomerMap     = _mapper.Map<SupplierProductCustomer, SupplierProductCustomerViewModel>(currentSupplierProductCustomer);
            return supplierProductCustomerMap;
        }

        public async Task<List<SupplierProductCustomerViewModel>> GetAll()
        {
            var listSupplierProductCustomer    = await _supplierProductCustomerRepository.GetAll() ?? new List<SupplierProductCustomer>();
            var listSupplierProductCustomerMap = _mapper.Map<List<SupplierProductCustomerViewModel>>(listSupplierProductCustomer);
            return listSupplierProductCustomerMap;
        }
    }
}