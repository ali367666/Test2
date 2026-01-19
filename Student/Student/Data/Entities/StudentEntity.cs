using System.ComponentModel.DataAnnotations;
using Student.Data.Attributes;

namespace Student.Data.Entities;

public class StudentEntity
{
    public int Id { get; set; }
    
    [Required]
    [MinLength(2)]
    [MaxLength(50)]
    public string FirstName { get; set; } = null!;
    
    [Required]
    [MinLength(2)]
    [MaxLength(50)]
    public string LastName { get; set; } = null!;
    
    [Required]
    [NotFutureDate]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }
}
