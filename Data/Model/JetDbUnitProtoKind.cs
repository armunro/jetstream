using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Jetstream.Data.Model;

[Table("UnitKind"), PrimaryKey(nameof(UnitId), nameof(ProtoId), nameof(KindId))]
public class JetDbUnitProtoKind
{
    
    public Guid UnitId { get; set; }
    public Guid ProtoId { get; set; }
    public Guid KindId { get; set; }
    
    public JetDbUnit Unit { get; set; }
    public JetDbProto Proto { get; set; }
    public JetDbKind Kind { get; set; }
    
}