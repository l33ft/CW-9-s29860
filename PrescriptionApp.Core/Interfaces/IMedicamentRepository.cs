using PrescriptionApp.Core.Entities;

namespace PrescriptionApp.Core.Interfaces;

public interface IMedicamentRepository
{
    Task<Medicament?> GetMedicamentByIdAsync(int id);
    Task<bool> MedicamentExistsAsync(int id);
    Task<List<Medicament>> GetMedicamentsByIdsAsync(List<int> ids);
}