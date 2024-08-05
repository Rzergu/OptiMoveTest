using GlobalETestLV.Core.Entities;
using GlobalETestLV.Core.Interfaces;
using GlobalETestLV.Data;
using GlobalETestLV.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace GlobalETestLV.Controllers;

[ApiController]
[Microsoft.AspNetCore.Mvc.Route("[controller]")]
public class SendedController : ControllerBase
{

    private readonly ILogger<CustomersController> _logger;
    private readonly IAsyncRepository<SendedRow> _sendedRepository;

    public SendedController(ILogger<CustomersController> logger, IAsyncRepository<SendedRow> sendedRepo)
    {
        _logger = logger;
        _sendedRepository = sendedRepo;
    }

    [Microsoft.AspNetCore.Mvc.HttpGet]
    public async Task<IActionResult> GetCustomersByFilterAsync()
    {
        var sended = await _sendedRepository.ListAllAsync();
        return Ok(sended);
    }
}
