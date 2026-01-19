namespace EFRelations.Data.Entities;

public class StudentWithGroups
{
    public int Id { get; set; }
    public string Name {  get; set; }
    public List<Student> Students { get; set; }
}
