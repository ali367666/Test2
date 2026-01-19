namespace OrmPorjectEF.Data.Entitiesad;

public class Student
{
    public int Id { get; set; }
    public string FullName { get; set; } = null!;
    public int? Age { get; set; } = null!;
    public double ?Score { get; set; } = null!;
    public bool?IsActive { get; set; } = null!;
    public string? Group { get; set; } = null!;

}
