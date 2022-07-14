using Microsoft.AspNetCore.Mvc;

namespace Jetstream.Controllers;

[ApiController]
[Route("[controller]")]
public class GatewayController : Controller
{
    // GET
    
    
    [HttpPost, Route("{gatewayId:guid}")]
    public object PostUnit(Guid gatewayId,  [FromBody] object unit)
    {
        return new { Message = "Got it", Unit = unit};
    }
}