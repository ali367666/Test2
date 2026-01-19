namespace RepeatTask.Data.Entities;

public class DepartmentDetails
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Department Department { get; set; } = null!;

}
