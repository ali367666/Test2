namespace TestPorjectAboutAPI.Entities;

public class Position
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public int ?DepartmentId { get; set; } = null!;
    public Department ?Department { get; set; } = null!;
}
