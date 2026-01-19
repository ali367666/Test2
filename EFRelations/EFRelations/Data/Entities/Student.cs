using System.Text.RegularExpressions;

namespace EFRelations.Data.Entities;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string FullName { get; set; }
    public int StudentDetailId { get; set; }
    public StudentDetails StudentDetail { get; set; }
    public int GroupId { get; set; }
    public Group Group { get; set; }
}
