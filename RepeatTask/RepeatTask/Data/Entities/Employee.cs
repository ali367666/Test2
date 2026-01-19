namespace RepeatTask.Data.Entities;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public ICollection<Payments> Payments { get; set; } = null!;
}
