namespace EFRelations.Data.Entities;

public class StudentDetails
{
    public int Id { get; set; }
    public string PassportNumber { get; set; }

    // Foreign Key
    public int StudentId { get; set; }

    public Student Student { get; set; }
}
