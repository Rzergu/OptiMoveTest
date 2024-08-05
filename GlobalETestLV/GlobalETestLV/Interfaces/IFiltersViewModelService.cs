using GlobalETestLV.ViewModels;

namespace GlobalETestLV.Interfaces
{
    public interface IFiltersViewModelService
    {
        Task<FilterViewModelIndex> GetAllFiltersAsync();
        Task AddFilter(FilterViewModel filter);
    }
}
