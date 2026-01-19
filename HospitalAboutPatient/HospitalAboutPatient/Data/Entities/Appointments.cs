using HospitalAboutPatient.Data.Enum;

namespace HospitalAboutPatient.Data.Entities;

public class Appointments
{
    public int DoctorId { get; set; }
    public Doctors  Doctor { get; set; } = null!;
    public int PatientId { get; set; }
    public Patient Patient { get; set; } = null!;
    public DateTime AppointmentDate { get; set; }
    public AppointmentStatus? Status { get; set; }= null!;

}
