using System.Text.Json;
using Jetstream.Data;
using Microsoft.AspNetCore.Mvc;

namespace Jetstream.Controllers;

[ApiController]
[Route("[controller]")]
public class GatewayController : Controller
{
   
    [HttpPost, Route("{gatewayId:guid}")]
    public object PostUnit(Guid gatewayId,  [FromBody] object unit)
    {
        JetstreamContext db = new JetstreamContext();
        
        db.unit.Add(new UnitDataModel(){
            Id = Guid.NewGuid(),
            GatewayId = gatewayId,
            Contents = JsonSerializer.Serialize(unit)
        });
        db.SaveChanges();
        
        return new { Message = "Got it", Unit = unit};
    }
}