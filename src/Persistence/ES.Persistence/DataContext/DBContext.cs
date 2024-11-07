using Microsoft.EntityFrameworkCore;

using ES.Domain.Entities;

namespace ES.Persistence.DataContext;
public class DbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public DbContext(DbContextOptions<DbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbContext).Assembly);
    }

    public DbSet<Account> Accounts { get; set; }
    public DbSet<Log> Logs { get; set; }


}
