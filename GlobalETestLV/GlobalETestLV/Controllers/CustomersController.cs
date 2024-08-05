using GlobalETestLV.Core.Entities;
using GlobalETestLV.Core.Interfaces;
using GlobalETestLV.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace GlobalETestLV.Controllers;

[ApiController]
[Microsoft.AspNetCore.Mvc.Route("[controller]")]
public class CustomersController : ControllerBase
{

    private readonly ILogger<CustomersController> _logger;
    private readonly ICustomersViewModelService _customersService;

    public CustomersController(ILogger<CustomersController> logger, ICustomersViewModelService customersService)
    {
        _logger = logger;
        _customersService = customersService;
    }
    [Microsoft.AspNetCore.Mvc.HttpGet]
    public async Task<IActionResult> GetCustomersByFilterAsync(int? filterId)
    {
        var customers = filterId == null ? await _customersService.GetAllCustomersAsync() 
            : await _customersService.GetCustomersByFilterIdAsync(filterId.Value);
        return Ok(customers.CustomerItem);
    }
}
