
namespace HospitalAboutPatient.Data.Entities;

public class Patient
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }
    public List<Appointments> Appointments { get; set; } = new();
}
