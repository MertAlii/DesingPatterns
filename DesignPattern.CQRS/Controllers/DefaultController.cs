using DesignPattern.CQRS.CQRSPattern.Handlers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.CQRS.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DefaultController : ControllerBase
{
    private readonly GetProductQueryHandler _getProductQueryHandler;

    public DefaultController(GetProductQueryHandler getProductQueryHandler)
    {
        _getProductQueryHandler = getProductQueryHandler;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var values = _getProductQueryHandler.Handle();
        return Ok(values);
    }
}
