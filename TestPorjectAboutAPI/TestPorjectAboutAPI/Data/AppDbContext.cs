using Microsoft.EntityFrameworkCore;

namespace TestPorjectAboutAPI.Data;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Entities.Department> Departments { get; set; } = null!;
    public DbSet<Entities.Position> Positions { get; set; } = null!;
}
