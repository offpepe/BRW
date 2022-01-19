using BRW.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace BRW.API.Context;

public class BrwAppContext: DbContext
{
    public BrwAppContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    
    public DbSet<Team> Teams { get; set; }

    public DbSet<Group> Groups { get; set; }
    
    public DbSet<Game> Games { get; set; }
    
    public DbSet<Prize> Prizes { get; set; }
    

}
