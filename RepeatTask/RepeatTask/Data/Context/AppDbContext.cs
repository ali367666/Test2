using Microsoft.EntityFrameworkCore;
using RepeatTask.Data.Entities;

namespace RepeatTask.Data.Context;

public class AppDbContext:DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Department>()
            .HasOne(d => d.DepartmentDetail)
            .WithOne(dd => dd.Department)
            .HasForeignKey<Department>(d => d.DPDetail);

        modelBuilder.Entity<Division>()
            .HasOne(d => d.Department)
            .WithMany(dep => dep.Divisions)
            .HasForeignKey(d => d.DepartmentId);

        modelBuilder.Entity<Payments>()
            .HasMany(p => p.Employees)
            .WithMany(e => e.Payments);
        
        modelBuilder.Entity<Country>()
            .HasMany(c => c.Cities)
            .WithOne(cy => cy.Country)
            .HasForeignKey(cy => cy.CountryId);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-ET5TVFM\SQLEXPRESS;
        Initial Catalog=NewRepatProject;
        Integrated Security=True;
        TrustServerCertificate=True;");
    }
    public DbSet<Department> Departments { get; set; }
    public DbSet<DepartmentDetails> DepartmentDetails { get; set; }
    public DbSet<Division> Divisions { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Payments> Payments { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<City> Cities { get; set; }

}
