using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewTestingORM.EF.Data.Entities;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    [ForeignKey("StudentDetail")]
    public int DetailId {  get; set; }
    public StudentDetail StudentDetail { get; set; } = null!;
    public int GroupID {  get; set; }
    public Group Group {  get; set; }
    public List<Cource> Cources { get; set; }
}
