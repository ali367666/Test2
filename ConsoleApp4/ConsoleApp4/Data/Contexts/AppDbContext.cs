using ConsoleApp4.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp4.Data.Contexts;

public class AppDbContext:DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
        @"Data Source=DESKTOP-ET5TVFM\SQLEXPRESS;
        Initial Catalog=PizzaMizzaTest;
        Integrated Security=True;
        TrustServerCertificate=True;");

    }
}
