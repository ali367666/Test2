using Microsoft.EntityFrameworkCore;
using Projects.Data;
using Projects.Models;

// Database connection string
var connectionString = "Server=(localdb)\\mssqllocaldb;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;";

// Configure services
var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
optionsBuilder.UseSqlServer(connectionString);

using var context = new ApplicationDbContext(optionsBuilder.Options);

// Ensure database is created
context.Database.EnsureCreated();

Console.WriteLine("Database created successfully!");
Console.WriteLine("Student and StudentDetail tables are ready with one-to-one relationship.");

// Example: Create a student with detail
var student = new Student
{
    Name = "Test Student",
    StudentDetail = new StudentDetail()
};

context.Students.Add(student);
context.SaveChanges();

Console.WriteLine($"Student created with ID: {student.ID}");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
