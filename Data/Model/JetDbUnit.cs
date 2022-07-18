using System.ComponentModel.DataAnnotations.Schema;

namespace Jetstream.Data.Model;

[Table("Unit")]
public class JetDbUnit
{
    public Guid Id { get; set; }
    public Guid GatewayId { get; set; }
    public JetDbGateway Gateway { get; set; }
    [Column(TypeName = "jsonb")]
    public string Contents { get; set; }
    
}