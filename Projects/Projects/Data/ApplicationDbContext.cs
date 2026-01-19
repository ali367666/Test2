using Microsoft.EntityFrameworkCore;
using Projects.Models;

namespace Projects.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<StudentDetail> StudentDetails { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Student configuration
        modelBuilder.Entity<Student>(entity =>
        {
            entity.ToTable("Student");
            entity.HasKey(e => e.ID);
            entity.Property(e => e.ID)
                .HasColumnName("ID")
                .ValueGeneratedOnAdd();
            entity.Property(e => e.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .IsRequired();

            // One-to-one relationship
            entity.HasOne(e => e.StudentDetail)
                .WithOne(e => e.Student)
                .HasForeignKey<StudentDetail>(e => e.StudentID)
                .OnDelete(DeleteBehavior.Cascade);
        });

        // StudentDetail configuration
        modelBuilder.Entity<StudentDetail>(entity =>
        {
            entity.ToTable("StudentDetail");
            entity.HasKey(e => e.ID);
            entity.Property(e => e.ID)
                .HasColumnName("ID")
                .ValueGeneratedOnAdd();
            entity.Property(e => e.StudentID)
                .HasColumnName("StudentID")
                .IsRequired();

            // One-to-one relationship
            entity.HasOne(e => e.Student)
                .WithOne(e => e.StudentDetail)
                .HasForeignKey<StudentDetail>(e => e.StudentID)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}

