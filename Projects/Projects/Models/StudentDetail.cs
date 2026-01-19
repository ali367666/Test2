namespace Projects.Models;

public class StudentDetail
{
    public int ID { get; set; }
    public int StudentID { get; set; } // Foreign key
    
    // One-to-one relationship
    public virtual Student Student { get; set; } = null!;
}

