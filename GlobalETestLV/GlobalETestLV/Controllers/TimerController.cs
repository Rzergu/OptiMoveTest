using GlobalETestLV.Core.Entities;
using GlobalETestLV.Core.Interfaces;
using GlobalETestLV.Interfaces;
using GlobalETestLV.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GlobalETestLV.Controllers;

[ApiController]
[Route("[controller]")]
public class TimerController : ControllerBase
{

    private readonly ILogger<TimerController> _logger;
    public readonly ITimersViewModelService _timersService;

    public TimerController(ITimersViewModelService timersService, ILogger<TimerController> logger)
    {
        _timersService = timersService;
        _logger = logger;
    }
    [HttpGet]
    public async Task<IActionResult> GetTimers()
    {
        _logger.LogInformation("GetTimers called.");
        var timers = await _timersService.GetAllTimersAsync();
        return Ok(timers.TimerItems);
    }
    [HttpPost]
    public async Task<IActionResult> AddTimer([FromBody] TimerViewModel newTimer)
    {
        _logger.LogInformation("AddTimer called.");
        await _timersService.AddTimer(newTimer);
        return Ok(newTimer);
    }
}

