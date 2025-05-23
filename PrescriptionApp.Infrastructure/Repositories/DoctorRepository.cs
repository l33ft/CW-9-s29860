using Microsoft.EntityFrameworkCore;
using PrescriptionApp.Core.Entities;
using PrescriptionApp.Core.Interfaces;
using PrescriptionApp.Infrastructure.Data;

namespace PrescriptionApp.Infrastructure.Repositories;

public class DoctorRepository : IDoctorRepository
{
    private readonly PrescriptionDbContext _context;

    public DoctorRepository(PrescriptionDbContext context)
    {
        _context = context;
    }

    public async Task<Doctor?> GetDoctorByIdAsync(int id)
    {
        return await _context.Doctors.FindAsync(id);
    }

    public async Task<bool> DoctorExistsAsync(int id)
    {
        return await _context.Doctors.AnyAsync(d => d.IdDoctor == id);
    }
}