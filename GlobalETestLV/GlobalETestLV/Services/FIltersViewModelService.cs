using GlobalETestLV.Core.Entities;
using GlobalETestLV.Core.Interfaces;
using GlobalETestLV.Data;
using GlobalETestLV.Interfaces;
using GlobalETestLV.ViewModels;

namespace GlobalETestLV.Services
{
    public class FiltersViewModelService : IFiltersViewModelService
    {
        private readonly IAsyncRepository<TimerFilter> _filterRepository;

        private readonly ILogger<FiltersViewModelService> _logger;
        public FiltersViewModelService(IAsyncRepository<TimerFilter> filterRepository, ILogger<FiltersViewModelService> logger)
        {
            _filterRepository = filterRepository;
            _logger = logger;
        }
        public async Task<FilterViewModelIndex> GetAllFiltersAsync()
        {
            _logger.LogInformation("GetAllFiltersAsync called.");
            var filtersItem = await _filterRepository.ListAllAsync();
            var vm = new FilterViewModelIndex()
            {
                FilterItems = filtersItem.Select(x => new FilterViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Cities = x.Cities,
                    Genders = x.Genders,
                    AgeFrom = x.AgeFrom,
                    AgeTo   = x.AgeTo,
                    DepositFrom = x.DepositFrom,
                    DepositTo = x.DepositTo,
                    IsNew = x.IsNew
                })
            };
            return vm;
        }
        public async Task AddFilter(FilterViewModel filter)
        {
            _logger.LogInformation("AddFilter called");
            var filterItem = new TimerFilter()
            {
               Id= filter.Id,
               Name = filter.Name,
               Genders= filter.Genders,
               Cities= filter.Cities,
               AgeFrom= filter.AgeFrom,
               AgeTo= filter.AgeTo,
               DepositFrom = filter.DepositFrom,
               DepositTo = filter.DepositTo,
               IsNew = filter.IsNew
            };
            await _filterRepository.AddAsync(filterItem);
        }
    }
}
