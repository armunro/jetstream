using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Jetstream.Data.Model;

[Table("Kind"), PrimaryKey("Id")]
public class JetDbKind
{
    public Guid Id { get; set; }
    public string Namespace { get; set; } 
    public string Name { get; set; } 
}
