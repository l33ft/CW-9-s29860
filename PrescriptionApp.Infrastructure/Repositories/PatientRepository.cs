using Microsoft.EntityFrameworkCore;
using PrescriptionApp.Core.Entities;
using PrescriptionApp.Core.Interfaces;
using PrescriptionApp.Infrastructure.Data;

namespace PrescriptionApp.Infrastructure.Repositories;

public class PatientRepository : IPatientRepository
{
    private readonly PrescriptionDbContext _context;

    public PatientRepository(PrescriptionDbContext context)
    {
        _context = context;
    }

    public async Task<Patient?> GetPatientByIdAsync(int id)
    {
        return await _context.Patients.FindAsync(id);
    }

    public async Task<Patient?> GetPatientWithPrescriptionsAsync(int id)
    {
        return await _context.Patients
            .Include(p => p.Prescriptions.OrderBy(pr => pr.DueDate))
            .ThenInclude(pr => pr.Doctor)
            .Include(p => p.Prescriptions)
            .ThenInclude(pr => pr.PrescriptionMedicaments)
            .ThenInclude(pm => pm.Medicament)
            .FirstOrDefaultAsync(p => p.IdPatient == id);
    }

    public async Task<Patient> AddPatientAsync(Patient patient)
    {
        _context.Patients.Add(patient);
        await _context.SaveChangesAsync();
        return patient;
    }

    public async Task<bool> PatientExistsAsync(int id)
    {
        return await _context.Patients.AnyAsync(p => p.IdPatient == id);
    }
}