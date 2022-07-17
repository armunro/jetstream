using System.ComponentModel.DataAnnotations.Schema;

namespace Jetstream.Data;

public class UnitDataModel
{
    public Guid Id { get; set; }
    public Guid GatewayId { get; set; }
    [Column(TypeName = "jsonb")]
    public string Contents { get; set; }
    
}