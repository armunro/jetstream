using System.ComponentModel.DataAnnotations.Schema;

namespace Jetstream.Data.Model;

[Table("Kind")]
public class JetDbKind
{
    public Guid Id { get; set; }
    public string Namespace { get; set; } 
    public string Name { get; set; } 
}
