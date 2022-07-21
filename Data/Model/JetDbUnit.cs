using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace Jetstream.Data.Model;

[Table("Unit")]
public class JetDbUnit
{
    public Guid Id { get; set; }
    public Guid GatewayId { get; set; }
    public JetDbGateway Gateway { get; set; }
    
    public JsonDocument Contents { get; set; }
    
}