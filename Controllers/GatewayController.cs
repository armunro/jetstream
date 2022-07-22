using System.ComponentModel;
using System.Text.Json;
using Jetstream.Data;
using Jetstream.Data.Model;
using Microsoft.AspNetCore.Mvc;
using Json.Path;

namespace Jetstream.Controllers;

[ApiController]
[Route("[controller]")]
public class GatewayController : Controller
{
    [HttpPost, Route("{gatewayId:guid}"),]
    public object PostUnit([DefaultValue("0202CE66-2504-4211-BA35-BCE32E527D41")] Guid gatewayId,
        [FromBody, DefaultValue(Globals.TaskA)]
        JsonDocument unit)
    {
        JetDbContext db = new JetDbContext();

        //Create the unit
        var dbUnit = new JetDbUnit
        {
            Id = Guid.NewGuid(),
            GatewayId = gatewayId,
            Contents = unit,
        };

        //determine which proto rules are assigned and apply 

        var protos = db.GatewayKindProtos.Where(x => x.GatewayId == gatewayId).Select(x => x.Proto);

        foreach (JetDbProto proto in protos)
        {
            if (!string.IsNullOrWhiteSpace(proto.Expression))
            {
                var pathResult = JsonPath.Parse(proto.Expression).Evaluate(unit.RootElement);
                if (pathResult.Matches.Any())
                {
                    db.UnitKinds.Add(new JetDbUnitProtoKind()
                    {
                        UnitId = dbUnit.Id,
                        KindId = proto.KindId,
                        ProtoId = proto.Id
                    });
                }
            }
        }


        db.Units.Add(dbUnit);
        db.SaveChanges();

        return new { UnitId = dbUnit.Id };
    }
}