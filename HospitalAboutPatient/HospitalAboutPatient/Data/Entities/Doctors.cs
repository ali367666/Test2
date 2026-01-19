namespace HospitalAboutPatient.Data.Entities;

public class Doctors
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Specialty { get; set; } = null!;
    public List<Appointments> Appointments { get; set; } = new();
}
