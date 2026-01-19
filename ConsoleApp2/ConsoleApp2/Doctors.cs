namespace ConsoleApp2;

public class Doctor
{
    public int ID { get; set; }
    public string FullName { get; set; }
    public string Speciality { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    public int HospitalID { get; set; }
    public Hospital Hospital { get; set; }

    public ICollection<Appointment> Appointments { get; set; }
}

