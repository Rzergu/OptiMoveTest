using GlobalETestLV.ViewModels;

namespace GlobalETestLV.Interfaces
{
    public interface ITimersViewModelService
    {
        Task<TimerViewModelIndex> GetAllTimersAsync();
        Task AddTimer(TimerViewModel filter);
    }
}
