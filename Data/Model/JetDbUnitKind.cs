using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Jetstream.Data.Model;

[Table("UnitKind"), PrimaryKey(nameof(UnitId), nameof(KindId))]
public class JetDbUnitKind
{
    
    public Guid UnitId { get; set; }
    public Guid KindId { get; set; }
    public JetDbUnit Unit { get; set; }
    public JetDbKind Kind { get; set; }
}