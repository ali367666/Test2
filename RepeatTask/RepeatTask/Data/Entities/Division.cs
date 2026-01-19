namespace RepeatTask.Data.Entities;

public class Division
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; } = null!;
}
