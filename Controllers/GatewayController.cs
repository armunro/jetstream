using System.ComponentModel;
using System.Text.Json;
using Jetstream.Data;
using Jetstream.Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace Jetstream.Controllers;

[ApiController]
[Route("[controller]")]
public class GatewayController : Controller
{
   
    [HttpPost, Route("{gatewayId:guid}"),]
    
    public object PostUnit([DefaultValue("0202CE66-2504-4211-BA35-BCE32E527D41")]Guid gatewayId,  [FromBody, DefaultValue(Globals.TaskA)] object unit)
    {
        JetDbContext db = new JetDbContext();

        
        var protos = db.Protos;
        


        var dbUnit = new JetDbUnit
        {
            Id = Guid.NewGuid(),
            GatewayId = gatewayId,
            Contents = JsonDocument.Parse(JsonSerializer.Serialize(unit))
        };
        
        db.Units.Add(dbUnit);
        db.SaveChanges();
        
        return new { UnitId = dbUnit.Id, AppliedProtos = protos};
    }
}