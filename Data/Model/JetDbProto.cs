using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Jetstream.Data.Model;

[Table("Proto"),PrimaryKey("Id")]
public class JetDbProto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    
    [Column(TypeName = "int")]
    public ProtoRole Role { get; set; }
    
    public string? Expression { get; set; }
    
    public JetDbKind Kind { get; set; }
    public Guid KindId { get; set; }
}