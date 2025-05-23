using PrescriptionApp.Core.Entities;

namespace PrescriptionApp.Core.Interfaces;

public interface IPatientRepository
{
    Task<Patient?> GetPatientByIdAsync(int id);
    Task<Patient?> GetPatientWithPrescriptionsAsync(int id);
    Task<Patient> AddPatientAsync(Patient patient);
    Task<bool> PatientExistsAsync(int id);
}