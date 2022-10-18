using AutoMapper;
using MyHardware.ViewModel;
using MyHardwareWeb.Application.Interfaces;
using MyHardwareWeb.Domain.Models;

namespace MyHardwareWeb.Infrastructure.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository,
            IMapper mapper)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }

        public async Task<CustomerViewModel> Save(CustomerViewModel model)
        {
            var customerMap = _mapper.Map<Customer>(model);
            await _customerRepository.Create(customerMap);
            return model;
        }

        public async Task<CustomerViewModel> Edit(CustomerViewModel model)
        {
            var customerMap = _mapper.Map<Customer>(model);
            await _customerRepository.Update(customerMap);
            return model;
        }

        public async Task<CustomerViewModel> FindByIdAsync(int id)
        {
            var currentCustomer = await _customerRepository.FindById(id) ?? new Customer();
            var customerMap     = _mapper.Map<CustomerViewModel>(currentCustomer);
            return customerMap;
        }

        public async Task<List<CustomerViewModel>> GetAll()
        {
            var listCustomer    = await _customerRepository.GetAll() ?? new List<Customer>();
            var listCustomerMap = _mapper.Map<List<CustomerViewModel>>(listCustomer);
            return listCustomerMap;
        }
    }
}