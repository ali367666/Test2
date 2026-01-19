namespace Projects.Models;

public class Student
{
    public int ID { get; set; }
    public string Name { get; set; } = string.Empty;
    
    // One-to-one relationship
    public virtual StudentDetail? StudentDetail { get; set; }
}

