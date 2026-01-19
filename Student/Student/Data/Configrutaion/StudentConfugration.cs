using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Student.Data.Entities;

namespace Student.Data.Configrutaion;

public class StudentConfugration : IEntityTypeConfiguration<StudentEntity>
{
    public void Configure(EntityTypeBuilder<StudentEntity> builder)
    {
        // Table name
        builder.ToTable("Students");
        
        // Primary key
        builder.HasKey(s => s.Id);
        
        // FirstName configuration
        builder.Property(s => s.FirstName)
            .IsRequired()
            .HasMaxLength(50)
            .HasColumnType("nvarchar(50)");
        
        // LastName configuration
        builder.Property(s => s.LastName)
            .IsRequired()
            .HasMaxLength(50)
            .HasColumnType("nvarchar(50)");
        
        // DateOfBirth configuration
        builder.Property(s => s.DateOfBirth)
            .IsRequired()
            .HasColumnType("date");
    }
}
