using PrescriptionApp.Core.Entities;

namespace PrescriptionApp.Core.Interfaces
{
    public interface IPrescriptionService
    {
        Task<Prescription> AddPrescriptionAsync(Prescription prescription); 
        Task<Prescription> GetPrescriptionByIdAsync(int id);
        Task<IEnumerable<Prescription>> GetPrescriptionsByPatientIdAsync(int patientId);
        Task<IEnumerable<Prescription>> GetPrescriptionsByDoctorIdAsync(int doctorId);
    }
}