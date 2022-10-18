using AutoMapper;
using MyHardware.ViewModel;
using MyHardwareWeb.Application.Interfaces;
using MyHardwareWeb.Domain.Models;

namespace MyHardwareWeb.Infrastructure.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly IMapper _mapper;

        public SupplierService(ISupplierRepository supplierRepository,
            IMapper mapper)
        {
            _mapper = mapper;
            _supplierRepository = supplierRepository;
        }

        public async Task<SupplierViewModel> Save(SupplierViewModel model)
        {
            var supplierMap = _mapper.Map<SupplierViewModel, Supplier>(model);
            await _supplierRepository.Create(supplierMap);
            return model;
        }

        public async Task<SupplierViewModel> Edit(SupplierViewModel model)
        {
            var supplierMap = _mapper.Map<SupplierViewModel, Supplier>(model);
            await _supplierRepository.Update(supplierMap);
            return model;
        }

        public async Task<SupplierViewModel> FindById(int id)
        {
            var currentSupplier = await _supplierRepository.FindById(id) ?? new Supplier();
            var supplierMap     = _mapper.Map<Supplier, SupplierViewModel>(currentSupplier);
            return supplierMap;
        }

        public async Task<List<SupplierViewModel>> GetAll()
        {
            var listSupplier    = await _supplierRepository.GetAll() ?? new List<Supplier>(); ;
            var listSupplierMap = _mapper.Map<List<SupplierViewModel>>(listSupplier);
            return listSupplierMap;
        }
    }
}