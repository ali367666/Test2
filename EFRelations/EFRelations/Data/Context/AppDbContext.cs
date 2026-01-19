using EFRelations.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFRelations.Data.Context;

public  class AppDbContext:DbContext
{
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-ET5TVFM\SQLEXPRESS;
        Initial Catalog=EFRelationsProject;
        Integrated Security=True;
        TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Student>()
            .HasOne(s => s.StudentDetail)
            .WithOne(sd => sd.Student)
            .HasForeignKey<Student>(s => s.StudentDetailId);

       
    }
    public DbSet<Student> Students { get; set; }
    public DbSet<StudentDetails> StudentDetails { get; set; }
    public DbSet<StudentWithGroups> StudentWithGroups { get; set; }
}
