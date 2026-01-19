
using Microsoft.EntityFrameworkCore;
using NewMigrationProject.Data.Entities;

namespace NewMigrationProject.Data.Contexts;

public class AppDbContext:DbContext
{
    public DbSet<Students> Students { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
        @"Data Source=DESKTOP-ET5TVFM\SQLEXPRESS;
        Initial Catalog=TestinMigration;
        Integrated Security=True;
        TrustServerCertificate=True;");
    }

}
