using Microsoft.AspNetCore.Mvc;

namespace Jetstream.Controllers;

[ApiController]
[Route("[controller]")]
public class GatewayController : Controller
{
    // GET
    [HttpPost(Name = "Create Unit")]
    public object PostUnit([FromBody] object unit)
    {
        return new { Message = "Got it", Unit = unit};
    }
}