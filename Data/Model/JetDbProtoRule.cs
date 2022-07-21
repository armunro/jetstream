using System.ComponentModel.DataAnnotations.Schema;

namespace Jetstream.Data.Model;

[Table("ProtoRule")]
public class JetDbProtoRule
{
    public Guid Id { get; set; }
    
    public Guid ProtoId { get; set; }
    public JetDbProto Proto { get; set; }
    public string? Expression { get; set; }
    
}