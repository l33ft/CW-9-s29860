using PrescriptionApp.Core.Entities;

namespace PrescriptionApp.Core.Interfaces;

public interface IDoctorRepository
{
    Task<Doctor?> GetDoctorByIdAsync(int id);
    Task<bool> DoctorExistsAsync(int id);
}