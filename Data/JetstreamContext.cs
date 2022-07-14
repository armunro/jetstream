using Microsoft.EntityFrameworkCore;

namespace Jetstream.Data;

public class JetstreamContext : DbContext
{
    public DbSet<JetUnit> Unit { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(@"Host=postgres.storage.svc.cluster.local;Username=jetstream;Password=password;Database=jetstream");
    
}

public class JetUnit
{
    public Guid Id { get; set; }
    
}