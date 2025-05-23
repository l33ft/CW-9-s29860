using Microsoft.EntityFrameworkCore;
using PrescriptionApp.Core.Entities;
using PrescriptionApp.Core.Interfaces;
using PrescriptionApp.Infrastructure.Data;

namespace PrescriptionApp.Infrastructure.Repositories;

public class PrescriptionRepository : IPrescriptionRepository
{
    private readonly PrescriptionDbContext _context;

    public PrescriptionRepository(PrescriptionDbContext context)
    {
        _context = context;
    }

    public async Task<Prescription> AddPrescriptionAsync(Prescription prescription)
    {
        _context.Prescriptions.Add(prescription);
        await _context.SaveChangesAsync();
        return prescription;
    }

    public async Task<List<Prescription>> GetPrescriptionsByPatientIdAsync(int patientId)
    {
        return await _context.Prescriptions
            .Where(p => p.IdPatient == patientId)
            .Include(p => p.Doctor)
            .Include(p => p.PrescriptionMedicaments)
            .ThenInclude(pm => pm.Medicament)
            .OrderBy(p => p.DueDate)
            .ToListAsync();
    }
}