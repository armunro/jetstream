using Jetstream.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Jetstream.Data;

public class JetDbContext : DbContext
{
    public DbSet<JetDbUnit> Units { get; set; }
    public DbSet<JetDbGateway> Gateways { get; set; }
    public DbSet<JetDbUnitKind> UnitKinds { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(@"Host=postgres.storage.svc.cluster.local;Username=jetstream;Password=password;Database=jetstream");
    
}