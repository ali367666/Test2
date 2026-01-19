namespace NewTestingORM.EF.Data.Entities;

public class StudentDetail
{
    public int Id { get; set; }
    public string FullDetails {  get; set; }
    public Student Student { get; set; } = null!;
}
