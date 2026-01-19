namespace ConsoleApp2;

public class Appointment
{
    public int ID { get; set; }
    public DateTime Date { get; set; }

    public int DoctorID { get; set; }
    public Doctor Doctor { get; set; }

    public int PatientID { get; set; }
    public Patient Patient { get; set; }
}

