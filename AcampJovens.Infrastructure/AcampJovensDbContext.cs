using System.Reflection;
using AcampJovens.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace AcampJovens.Infrastructure;

public class AcampJovensDbContext : DbContext
{
    public AcampJovensDbContext(DbContextOptions<AcampJovensDbContext> options): base(options) {}
    
    public DbSet<Message> Messages { get; set; }
    public DbSet<Audio> Audios { get; set; }
    public DbSet<Camper> Campers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}