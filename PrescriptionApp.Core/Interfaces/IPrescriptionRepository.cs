using PrescriptionApp.Core.Entities;

namespace PrescriptionApp.Core.Interfaces;

public interface IPrescriptionRepository
{
    Task<Prescription> AddPrescriptionAsync(Prescription prescription);
    Task<List<Prescription>> GetPrescriptionsByPatientIdAsync(int patientId);
}