using Microsoft.EntityFrameworkCore;
using Student.Data.Configrutaion;
using Student.Data.Entities;

namespace Student.Data.Context;

public class AppDbContext:DbContext
{
    public DbSet<StudentEntity> Students { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-ET5TVFM\SQLEXPRESS;
        Initial Catalog=StudentProjects;
        Integrated Security=True;
        TrustServerCertificate=True;");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new StudentConfugration());
    }
}
