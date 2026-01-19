using HospitalAboutPatient.Data.Entities;
using HospitalAboutPatient.Data.Enum;
using Microsoft.EntityFrameworkCore;

namespace HospitalAboutPatient.Data.Context;


public class AppDbContext:DbContext
{
    public DbSet<Patient> Patients { get; set; } = null!;
    public DbSet<Doctors> Doctors { get; set; } = null!;
    public DbSet<Appointments> Appointments { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-ET5TVFM\SQLEXPRESS;
        Initial Catalog=HospitalsProject;
        Integrated Security=True;
        TrustServerCertificate=True;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointments>()
            .HasKey(a => new { a.DoctorId, a.PatientId });
    }



}
