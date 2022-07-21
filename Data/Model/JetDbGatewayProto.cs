using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Jetstream.Data.Model;

[Table("GatewayProto"), PrimaryKey(nameof(GatewayId), nameof(ProtoId))]
public class JetDbGatewayProto
{
    public Guid GatewayId { get; set; }
    public Guid ProtoId { get; set; }
    public JetDbGateway Gateway { get; set; }
    public JetDbProto Proto { get; set; }
}