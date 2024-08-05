using GlobalETestLV.Core.Entities;
using GlobalETestLV.Core.Specifications;
using GlobalETestLV.Data;
using Quartz;

namespace GlobalETestLV.Jobs
{
    [DisallowConcurrentExecution]
    public class SendStrategiesJob : IJob
    {
        private readonly ILogger<SendStrategiesJob> _logger;

        private readonly IAsyncRepository<Customer> _customerRepository;
        private readonly IAsyncRepository<SendedRow> _sendedRepository;

        private readonly IAsyncRepository<TimerItem> _timerRepository;


        public SendStrategiesJob(ILogger<SendStrategiesJob> logger, IAsyncRepository<Customer> customerRepository, IAsyncRepository<TimerItem> timerRepository, IAsyncRepository<SendedRow> sendedRepository)
        {
            _logger = logger;
            _customerRepository = customerRepository;
            _sendedRepository = sendedRepository;
            _timerRepository = timerRepository;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            _logger.LogInformation("Send Row!");
            JobDataMap dataMap = context.JobDetail.JobDataMap;

            var timerId = dataMap.GetInt("timerId");
            var timer = await _timerRepository.GetByIdAsync(timerId);
            var customers = await _customerRepository.ListAsync(new GetCustomersByStrategySpecification(timerId));
            await _sendedRepository.AddBatchAsync(customers.Select(customer =>
                    new SendedRow { CustomerId = customer.Id, SendTime = DateTime.UtcNow, TemplateId = timer.TemplateId }));
        }
    }
}
