using GlobalETestLV.Core.Entities;
using GlobalETestLV.Core.Interfaces;
using GlobalETestLV.Core.Specifications;
using GlobalETestLV.Data;
using GlobalETestLV.Interfaces;
using GlobalETestLV.ViewModels;
using Microsoft.AspNetCore.Mvc.Filters;
using Quartz;

namespace GlobalETestLV.Services
{
    public class CustomersViewModelService : ICustomersViewModelService
    {
        private readonly IAsyncRepository<Customer> _customerRepository;
        private readonly IAsyncRepository<TimerFilter> _filterRepository;
        private readonly ILogger<CustomersViewModelService> _logger;
        public CustomersViewModelService(IAsyncRepository<Customer> customerRepository, IAsyncRepository<TimerFilter> filterRepository, ILogger<CustomersViewModelService> logger)
        {
            _customerRepository = customerRepository;
            _filterRepository = filterRepository;
            _logger = logger;
        }
        public async Task<CustomerViewModelIndex> GetAllCustomersAsync()
        {
            _logger.LogInformation("GetAllCustomersAsync called.");
            var customersItem = await _customerRepository.ListAllAsync();
            var vm = new CustomerViewModelIndex()
            {
                CustomerItem = customersItem.Select(x => new CustomerViewModel()
                {
                    Id = x.Id,
                    Age = x.Age,
                    City = x.City,
                    Deposit = x.Deposit,
                    Gender = x.Gender,
                    IsNew = x.IsNew
                })
            };
            return vm;
        }
        public async Task<CustomerViewModelIndex> GetCustomersByFilterIdAsync(int filterId)
        {
            _logger.LogInformation("GetCustomersByFilterIdAsync called.");

            var filter = await _filterRepository.GetByIdAsync(filterId);
            var customersItem = await _customerRepository.ListAsync(new CustomerByFilterSpecification(filter));

            var vm = new CustomerViewModelIndex()
            {
                //TODO: Add Mapper
                CustomerItem = customersItem.Select(x => new CustomerViewModel()
                {
                    Id = x.Id,
                    Age = x.Age,
                    City = x.City,
                    Deposit = x.Deposit,
                    Gender = x.Gender,
                    IsNew = x.IsNew
                })
            };
            return vm;
        }
    }
}
