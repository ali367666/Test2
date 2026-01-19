using System.Numerics;

namespace ConsoleApp2;

public class Hospital
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    // 1 Hospital → Many Doctors
    public ICollection<Doctor> Doctors { get; set; }
}
