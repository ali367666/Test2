namespace NewTestingORM.EF.Data.Entities;

public class Cource
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Student> Students { get; set; }
}
