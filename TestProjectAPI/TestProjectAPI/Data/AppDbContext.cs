using Microsoft.EntityFrameworkCore;

namespace TestProjectAPI.Data;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Entities.Student> Students { get; set; }
}
