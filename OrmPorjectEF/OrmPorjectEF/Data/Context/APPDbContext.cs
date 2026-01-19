using Microsoft.EntityFrameworkCore;
using OrmPorjectEF.Data.Entitiesad;

namespace OrmPorjectEF.Data.Context;

public class APPDbContext:DbContext
{
    public DbSet<Student> Students { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-ET5TVFM\SQLEXPRESS;
        Initial Catalog=testMigration;
        Integrated Security=True;
        TrustServerCertificate=True;");
    }
}
