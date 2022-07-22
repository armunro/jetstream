using Jetstream.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Jetstream.Data;

public class JetDbContext : DbContext
{
    public DbSet<JetDbUnit> Units { get; set; }
    public DbSet<JetDbGateway> Gateways { get; set; }
    public DbSet<JetDbUnitProtoKind> UnitKinds { get; set; }
    public DbSet<JetDbProto> Protos { get; set; }
    
    public DbSet<JetDbGatewayProto> GatewayKindProtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(
            @"Host=postgres.storage.svc.cluster.local;Username=jetstream;Password=password;Database=jetstream");


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Guid newProtoId = Guid.Parse("D8C81623-0FD2-49C0-9E09-43242C962996");
        Guid newGatewayId = Guid.Parse("0202CE66-2504-4211-BA35-BCE32E527D41");
        Guid newKindId = Guid.Parse("B4E3C63F-78B0-4382-A434-A00D9D3E61F9");
            
        modelBuilder.Entity<JetDbGateway>().HasData(new JetDbGateway()
        {
            Id = newGatewayId,
            Name = "Sample Task Gateway",
            Description = "Accepts task objects and prototypes data around due dates. "
        });

        modelBuilder.Entity<JetDbKind>().HasData(new List<JetDbKind>()
        {
            new JetDbKind() {Id = newKindId, Name = "Due Date", Namespace = "Jetstream.Core"}
        });
        modelBuilder.Entity<JetDbProto>().HasData(new List<JetDbProto>()
        {
            new() { Id = newProtoId, Name = "Task Due Date", KindId = newKindId, Expression = "$.Date"}
        });
        
    
        
        modelBuilder.Entity<JetDbGatewayProto>().HasData(new List<JetDbGatewayProto>()
        {
            new() {GatewayId = newGatewayId, ProtoId = newProtoId}
        });
        base.OnModelCreating(modelBuilder);
    }
}