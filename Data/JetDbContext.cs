using Jetstream.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Jetstream.Data;

public class JetDbContext : DbContext
{
    public DbSet<JetDbUnit> Units { get; set; }
    public DbSet<JetDbGateway> Gateways { get; set; }
    public DbSet<JetDbUnitKind> UnitKinds { get; set; }
    public DbSet<JetDbProto> Protos { get; set; }
    public DbSet<JetDbProtoRule> ProtoRules { get; set; }
    public DbSet<JetDbGatewayProto> GatewayKindProtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(
            @"Host=postgres.storage.svc.cluster.local;Username=jetstream;Password=password;Database=jetstream");


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Guid newProtoId = Guid.Parse("D8C81623-0FD2-49C0-9E09-43242C962996");
        Guid newGatewayId = Guid.Parse("0202CE66-2504-4211-BA35-BCE32E527D41");
            
        modelBuilder.Entity<JetDbGateway>().HasData(new JetDbGateway()
        {
            Id = newGatewayId,
            Name = "Sample - Task Gateway",
            Description = "For testing and demo purposes"
        });
        modelBuilder.Entity<JetDbProto>().HasData(new List<JetDbProto>()
        {
            new() { Id = newProtoId, Name = "Task Proto" }
        });
        
        modelBuilder.Entity<JetDbProtoRule>().HasData(new List<JetDbProtoRule>()
        {
            new() { Id = Guid.NewGuid(), ProtoId = newProtoId, Expression = ""}
        });
        
        modelBuilder.Entity<JetDbGatewayProto>().HasData(new List<JetDbGatewayProto>()
        {
            new() {GatewayId = newGatewayId, ProtoId = newProtoId}
        });
        base.OnModelCreating(modelBuilder);
    }
}