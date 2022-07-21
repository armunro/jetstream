using System.ComponentModel.DataAnnotations.Schema;

namespace Jetstream.Data.Model;

[Table("Proto")]
public class JetDbProto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}