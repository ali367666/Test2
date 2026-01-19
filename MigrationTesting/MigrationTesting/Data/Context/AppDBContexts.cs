
using Microsoft.EntityFrameworkCore;

namespace MigrationTesting.Data.Context;

public class AppDBContexts:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-ET5TVFM\SQLEXPRESS;
        Initial Catalog=NewProjectMigration;
        Integrated Security=True;
        TrustServerCertificate=True;");
    }
}
