namespace RepeatTask.Data.Entities;

public class Payments
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
    public ICollection<Employee> Employees { get; set; } = null!;
}
