using GlobalETestLV.Core.Entities;
using GlobalETestLV.Core.Interfaces;
using GlobalETestLV.Interfaces;
using GlobalETestLV.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GlobalETestLV.Controllers;

[ApiController]
[Route("[controller]")]
public class TimerFilterController : ControllerBase
{

    private readonly ILogger<TimerController> _logger;
    public readonly IFiltersViewModelService _timerFilterService;

    public TimerFilterController(ILogger<TimerController> logger, IFiltersViewModelService timerFilterRepo)
    {
        _logger = logger;
        _timerFilterService = timerFilterRepo;
    }
    [HttpGet]
    public async Task<IActionResult> GetFilters()
    {
        _logger.LogInformation("GetFilters called.");
        var filters = await _timerFilterService.GetAllFiltersAsync();
        return Ok(filters.FilterItems);
    }
    [HttpPost]
    public async Task<IActionResult> AddFilter([FromBody] FilterViewModel newFilter)
    {
        _logger.LogInformation("AddFilter called.");
        await _timerFilterService.AddFilter(newFilter);
        return Ok(newFilter);
    }
}

