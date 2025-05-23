using Microsoft.EntityFrameworkCore;
using PrescriptionApp.Core.Entities;
using PrescriptionApp.Core.Interfaces;
using PrescriptionApp.Infrastructure.Data;

namespace PrescriptionApp.Infrastructure.Repositories;

public class MedicamentRepository : IMedicamentRepository
{
    private readonly PrescriptionDbContext _context;

    public MedicamentRepository(PrescriptionDbContext context)
    {
        _context = context;
    }

    public async Task<Medicament?> GetMedicamentByIdAsync(int id)
    {
        return await _context.Medicaments.FindAsync(id);
    }

    public async Task<bool> MedicamentExistsAsync(int id)
    {
        return await _context.Medicaments.AnyAsync(m => m.IdMedicament == id);
    }

    public async Task<List<Medicament>> GetMedicamentsByIdsAsync(List<int> ids)
    {
        return await _context.Medicaments
            .Where(m => ids.Contains(m.IdMedicament))
            .ToListAsync();
    }
}