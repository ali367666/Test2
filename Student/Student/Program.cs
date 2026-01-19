using System.ComponentModel.DataAnnotations;
using Student.Data.Context;
using Student.Data.Entities;

Console.WriteLine("=== Student Management System ===\n");

// Database context yaratmaq
using var context = new AppDbContext();

try
{
    // Database yaradılması (migration olmadan)
    context.Database.EnsureCreated();
    Console.WriteLine("Database yaradıldı və ya mövcuddur.\n");

    // Nümunə 1: Valid tələbə məlumatı əlavə etmək
    Console.WriteLine("--- Nümunə 1: Valid tələbə əlavə edilir ---");
    var student1 = new StudentEntity
    {
        FirstName = "Əli",
        LastName = "Məmmədov",
        DateOfBirth = new DateTime(2000, 5, 15)
    };

    if (ValidateStudent(student1))
    {
        context.Students.Add(student1);
        context.SaveChanges();
        Console.WriteLine($"✓ Tələbə uğurla əlavə edildi: {student1.FirstName} {student1.LastName} (ID: {student1.Id})\n");
    }

    // Nümunə 2: Başqa valid tələbə
    Console.WriteLine("--- Nümunə 2: İkinci valid tələbə əlavə edilir ---");
    var student2 = new StudentEntity
    {
        FirstName = "Ayşə",
        LastName = "Həsənova",
        DateOfBirth = new DateTime(2001, 8, 20)
    };

    if (ValidateStudent(student2))
    {
        context.Students.Add(student2);
        context.SaveChanges();
        Console.WriteLine($"✓ Tələbə uğurla əlavə edildi: {student2.FirstName} {student2.LastName} (ID: {student2.Id})\n");
    }

    // Nümunə 3: Validation xətası ilə tələbə (FirstName çox qısa)
    Console.WriteLine("--- Nümunə 3: Validation xətası (FirstName çox qısa) ---");
    var invalidStudent1 = new StudentEntity
    {
        FirstName = "A", // MinLength(2) tələb olunur
        LastName = "Testov",
        DateOfBirth = new DateTime(2002, 3, 10)
    };
    ValidateStudent(invalidStudent1);
    Console.WriteLine();

    // Nümunə 4: Validation xətası (DateOfBirth gələcəkdə)
    Console.WriteLine("--- Nümunə 4: Validation xətası (DateOfBirth gələcəkdə) ---");
    var invalidStudent2 = new StudentEntity
    {
        FirstName = "Test",
        LastName = "User",
        DateOfBirth = DateTime.Now.AddDays(1) // Gələcək tarix
    };
    ValidateStudent(invalidStudent2);
    Console.WriteLine();

    // Nümunə 5: Bütün tələbələri göstərmək
    Console.WriteLine("--- Nümunə 5: Bütün tələbələr ---");
    var allStudents = context.Students.ToList();
    
    if (allStudents.Any())
    {
        Console.WriteLine($"Cəmi {allStudents.Count} tələbə tapıldı:\n");
        foreach (var student in allStudents)
        {
            Console.WriteLine($"ID: {student.Id}");
            Console.WriteLine($"Ad: {student.FirstName}");
            Console.WriteLine($"Soyad: {student.LastName}");
            Console.WriteLine($"Doğum tarixi: {student.DateOfBirth:yyyy-MM-dd}");
            Console.WriteLine($"Yaş: {CalculateAge(student.DateOfBirth)}");
            Console.WriteLine("---");
        }
    }
    else
    {
        Console.WriteLine("Heç bir tələbə tapılmadı.");
    }

    // Nümunə 6: Tələbə axtarmaq
    Console.WriteLine("\n--- Nümunə 6: Tələbə axtarmaq ---");
    var searchResult = context.Students
        .Where(s => s.FirstName.Contains("Əli"))
        .FirstOrDefault();
    
    if (searchResult != null)
    {
        Console.WriteLine($"Tapıldı: {searchResult.FirstName} {searchResult.LastName}");
    }
    else
    {
        Console.WriteLine("Axtarış nəticəsi tapılmadı.");
    }

    // Nümunə 7: Tələbə məlumatını yeniləmək
    Console.WriteLine("\n--- Nümunə 7: Tələbə məlumatını yeniləmək ---");
    if (student1.Id > 0)
    {
        var studentToUpdate = context.Students.Find(student1.Id);
        if (studentToUpdate != null)
        {
            studentToUpdate.FirstName = "Əliyev";
            studentToUpdate.LastName = "Məmmədov";
            context.SaveChanges();
            Console.WriteLine($"✓ Tələbə məlumatı yeniləndi: {studentToUpdate.FirstName} {studentToUpdate.LastName}");
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Xəta baş verdi: {ex.Message}");
    if (ex.InnerException != null)
    {
        Console.WriteLine($"Daxili xəta: {ex.InnerException.Message}");
    }
}

Console.WriteLine("\n=== Proqram tamamlandı ===");

// Validation metodu
static bool ValidateStudent(StudentEntity student)
{
    var validationContext = new ValidationContext(student);
    var validationResults = new List<ValidationResult>();
    
    bool isValid = Validator.TryValidateObject(student, validationContext, validationResults, true);
    
    if (!isValid)
    {
        Console.WriteLine("✗ Validation xətaları:");
        foreach (var error in validationResults)
        {
            Console.WriteLine($"  - {error.ErrorMessage}");
        }
        return false;
    }
    
    return true;
}

// Yaş hesablama metodu
static int CalculateAge(DateTime dateOfBirth)
{
    var today = DateTime.Today;
    var age = today.Year - dateOfBirth.Year;
    if (dateOfBirth.Date > today.AddYears(-age)) age--;
    return age;
}
