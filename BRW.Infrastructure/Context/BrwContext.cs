using BRW.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace BRW.Infrastructure.Context;

public class BrwContext : DbContext
{
    public BrwContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Championship> Championships { get; set; }
    public DbSet<Prize> Prizes { get; set; }

    protected override void OnModelCreating(ModelBuilder model)
    {
        model.Entity<User>(e => e.Property(ent => ent.Guid).HasDefaultValueSql("gen_random_uuid()"));
        model.Entity<Team>(e => e.Property(ent => ent.Guid).HasDefaultValueSql("gen_random_uuid()"));
        model.Entity<Group>(e => e.Property(ent => ent.Guid).HasDefaultValueSql("gen_random_uuid()"));
        model.Entity<Championship>(e => e.Property(ent => ent.Guid).HasDefaultValueSql("gen_random_uuid()"));
        model.Entity<Prize>(e => e.Property(ent => ent.Guid).HasDefaultValueSql("gen_random_uuid()"));
    }
}