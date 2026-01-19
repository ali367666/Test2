using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepeatTask.Data.Entities;

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    
    public int DPDetail { get; set; }
    public DepartmentDetails DepartmentDetail { get; set; } = null!;
    public ICollection<Division> Divisions { get; set; } = null!;

}
