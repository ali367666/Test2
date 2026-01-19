// See https://aka.ms/new-console-template for more information
using HospitalAboutPatient.Data.Context;
using HospitalAboutPatient.Data.Entities;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

//1) Patients
//-------- -
//Id INT PK IDENTITY
//FullName NVARCHAR(100)
//BirthDate DATE

//2) Doctors
//---------
//Id INT PK IDENTITY
//FullName NVARCHAR(100)

//3) Appointments
//---------
//Id INT PK IDENTITY
//PatientId INT FK -> Patients(Id)
//DoctorId INT FK -> Doctors(Id)
//AppointmentDate DATETIME
//Status NVARCHAR(20)

//4) AppointmentLogs (TRIGGER üçün)
//---------
//Id INT PK IDENTITY
//AppointmentId INT
//ActionType NVARCHAR(20)   -- INSERT / UPDATE
//ActionDate DATETIME
// MENE BU TASKLARI cLASS KIMI YAZ

AppDbContext appDbContext = new AppDbContext();
//Doctors doctor = new Doctors
//{
//    FirstName = "John",
//    LastName = "Doe",
//    Specialty = "Cardiology"
//};
//Doctors doctor2 = new Doctors
//{
//    FirstName = "Jane",
//    LastName = "Smith",
//    Specialty = "Neurology"
//};
//Doctors doctor3 = new Doctors
//{
//    FirstName = "Emily",
//    LastName = "Johnson",
//    Specialty = "Pediatrics"
//};
//Doctors doctor4 = new Doctors
//{
//    FirstName = "Michael",
//    LastName = "Brown",
//    Specialty = "Orthopedics"
//};
//appDbContext.Doctors.AddRange(doctor,doctor2,doctor3,doctor4);
//appDbContext.SaveChanges();

//Patient patient = new Patient
//{
//    FirstName = "Alice",
//    LastName = "Williams",
//    DateOfBirth = new DateTime(1990, 5, 15)
//};
//Patient patient2 = new Patient
//{
//    FirstName = "Bob",
//    LastName = "Jones",
//    DateOfBirth = new DateTime(1985, 8, 22)
//};
//Patient patient3 = new Patient
//{
//    FirstName = "Charlie",
//    LastName = "Garcia",
//    DateOfBirth = new DateTime(2000, 12, 3)
//};
//Patient patient4 = new Patient 
//{
//    FirstName = "Diana",
//    LastName = "Martinez",
//    DateOfBirth = new DateTime(1995, 3, 30)
//};
//appDbContext.Patients.AddRange(patient, patient2, patient3, patient4);
//appDbContext.SaveChanges();

//Appointments appointment = new Appointments
//{
//    DoctorId = 1,
//    PatientId = 2,
//    AppointmentDate = new DateTime(2024, 7, 10, 14, 0, 0),
//    Status = HospitalAboutPatient.Data.Enum.AppointmentStatus.Scheduled

//};
//Appointments appointment2 = new Appointments
//{
//    DoctorId = 2,
//    PatientId = 3,
//    AppointmentDate = new DateTime(2024, 7, 11, 10, 30, 0),
//    Status = HospitalAboutPatient.Data.Enum.AppointmentStatus.Completed
//};
//Appointments appointment3 = new Appointments
//{
//    DoctorId = 3,
//    PatientId = 4,
//    AppointmentDate = new DateTime(2024, 7, 12, 9, 0, 0),
//    Status = HospitalAboutPatient.Data.Enum.AppointmentStatus.Canceled
//};
//Appointments appointment4 = new Appointments
//{
//    DoctorId = 4,
//    PatientId = 1,
//    AppointmentDate = new DateTime(2024, 7, 13, 11, 15, 0),
//    Status = HospitalAboutPatient.Data.Enum.AppointmentStatus.Scheduled
//};
//appDbContext.Appointments.AddRange(appointment, appointment2, appointment3, appointment4);
//appDbContext.SaveChanges();

//Patient patient = appDbContext.Patients.FirstOrDefault(p => p.Id == 1);
//Console.WriteLine($"Patient: {patient.FirstName} {patient.LastName}, DOB: {patient.DateOfBirth.ToShortDateString()}");

//var patient=appDbContext.Patients
//    .SelectMany(p => p.Appointments
//    .Where(a => a.Status == HospitalAboutPatient.Data.Enum.AppointmentStatus.Scheduled)
//    .Select(a => p)
//    .ToList();
//foreach(var pat in patient)
//{
//    Console.WriteLine($"Patient: {pat.FirstName} {pat.LastName}");
//}
appDbContext.Database.Migrate();
//var patient=appDbContext.Patients.Include(p=>p.Appointments).ThenInclude(a=>a.Doctor)
//    .ToList();
//foreach(var pat in patient)
//{
//    Console.WriteLine($"{pat.FirstName}-{pat.LastName}");
//}
