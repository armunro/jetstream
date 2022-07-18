using System.ComponentModel.DataAnnotations.Schema;

namespace Jetstream.Data.Model;

[Table("Gateway")]
public class JetDbGateway
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}