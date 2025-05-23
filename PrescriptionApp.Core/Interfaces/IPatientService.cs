using PrescriptionApp.Core.Entities;

namespace PrescriptionApp.Core.Interfaces
{
    public interface IPatientService
    {
        Task<Patient> GetPatientByIdAsync(int id);
        Task<Patient> GetPatientWithPrescriptionsAsync(int id); // ← DODAJ
        Task<IEnumerable<Patient>> GetAllPatientsAsync();
        Task<Patient> CreatePatientAsync(Patient patient);
        Task<Patient> UpdatePatientAsync(Patient patient);
        Task<bool> DeletePatientAsync(int id);
    }
}