using Microsoft.EntityFrameworkCore;
using NewTestingORM.EF.Data.Entities;

namespace NewTestingORM.EF.Data.Context;

public class AppDbContext:DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<StudentDetail> StudentDetail { get; set; }
    public DbSet<Group> Groups { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-ET5TVFM\SQLEXPRESS;
        Initial Catalog=TestProjectORM2;
        Integrated Security=True;
        TrustServerCertificate=True;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Student>()
            .HasMany(s => s.Cources)
            .WithMany(sd => sd.Students)
            .UsingEntity(j => j.ToTable("StudentCourses")); 
    }
    
}
