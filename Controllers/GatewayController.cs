using System.Text.Json;
using Jetstream.Data;
using Jetstream.Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace Jetstream.Controllers;

[ApiController]
[Route("[controller]")]
public class GatewayController : Controller
{
   
    [HttpPost, Route("{gatewayId:guid}")]
    public object PostUnit(Guid gatewayId,  [FromBody] object unit)
    {
        JetDbContext db = new JetDbContext();
        
        db.Units.Add(new JetDbUnit(){
            Id = Guid.NewGuid(),
            GatewayId = gatewayId,
            Contents = JsonSerializer.Serialize(unit)
        });
        db.SaveChanges();
        
        return new { Message = "Got it", Unit = unit};
    }
}