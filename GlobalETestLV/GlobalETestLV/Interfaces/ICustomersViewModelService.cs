using GlobalETestLV.Core.Entities;
using GlobalETestLV.ViewModels;

namespace GlobalETestLV.Interfaces
{
    public interface ICustomersViewModelService
    {
        Task<CustomerViewModelIndex> GetCustomersByFilterIdAsync(int filter);
        Task<CustomerViewModelIndex> GetAllCustomersAsync();
    }
}
