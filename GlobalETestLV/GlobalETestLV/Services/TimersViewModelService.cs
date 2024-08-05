using GlobalETestLV.Core.Entities;
using GlobalETestLV.Core.Interfaces;
using GlobalETestLV.Core.Specifications;
using GlobalETestLV.Data;
using GlobalETestLV.Interfaces;
using GlobalETestLV.Jobs;
using GlobalETestLV.ViewModels;
using Quartz;

namespace GlobalETestLV.Services
{
    public class TimersViewModelService : ITimersViewModelService
    {
        private readonly IAsyncRepository<TimerItem> _timerRepository;
        private readonly IAsyncRepository<TimerFilter> _filterRepository;
        private readonly IAsyncRepository<Customer> _customerRepository;

        private readonly ISchedulerFactory _schedulerFactory;

        private readonly ILogger<TimersViewModelService> _logger;
        public TimersViewModelService(IAsyncRepository<TimerItem> timerRepository, IAsyncRepository<Customer> customerRepository, IAsyncRepository<TimerFilter> filterRepository, ISchedulerFactory schedulerFactory, ILogger<TimersViewModelService> logger)
        {
            _timerRepository = timerRepository;
            _filterRepository = filterRepository;
            _schedulerFactory = schedulerFactory;
            _customerRepository = customerRepository;

            _logger = logger;
        }
        public async Task AddTimer(TimerViewModel timer)
        {
            _logger.LogInformation("AddTimer called");
            var timeOnly = TimeOnly.Parse(timer.Time);

            var filterEntity = await _filterRepository.GetByIdAsync(timer.FilterId);
            var count = await _timerRepository.CountAsync(new SameTimeTimersSpecification(timeOnly));
            var timerModel = new TimerItem()
            {
                Id = timer.Id,
                Filter = filterEntity,
                Time = timeOnly,
                Priority = timer.Priority,
                TemplateId = timer.TemplateId,
            };
            var newTimerEntity = await _timerRepository.AddAsync(timerModel);
            if (count == 0)
            {
                var scheduler = await _schedulerFactory.GetScheduler();
                IJobDetail job = JobBuilder.Create<SendStrategiesJob>()
                     .WithIdentity($"jotTimer{newTimerEntity.Id}", "jobs")
                     .UsingJobData("timerId", newTimerEntity.Id)
                     .Build();

                ITrigger trigger = TriggerBuilder.Create()
                     .WithIdentity($"trigger{newTimerEntity.Id}", "timers")
                     .WithSchedule(CronScheduleBuilder.DailyAtHourAndMinute(timeOnly.Hour, timeOnly.Minute))
                     .ForJob(new JobKey($"jotTimer{newTimerEntity.Id}", "jobs"))
                     .Build();


                await scheduler.ScheduleJob(job, trigger);
            }
            await _customerRepository.UpdateBySpecificationAsync(new CustomersByFilterWithLowerOrSamePriority(filterEntity, timerModel.Priority), x=> x.SetProperty(x => x.TimerItemId, newTimerEntity.Id));
        }

        public async Task<TimerViewModelIndex> GetAllTimersAsync()
        {
            _logger.LogInformation("GetAllTimersAsync called.");
            var filtersItem = await _timerRepository.ListAsync(new TimerWithFilterSpecification());
            var vm = new TimerViewModelIndex()
            {
                TimerItems = filtersItem.Select(x => new TimerViewModel()
                {
                    Id = x.Id,
                    FilterId = x.Filter.Id,
                    TemplateId = x.TemplateId,
                    Priority = x.Priority,
                    Time    = x.Time.ToString(),
                })
            };
            return vm;
        }
    }
}
