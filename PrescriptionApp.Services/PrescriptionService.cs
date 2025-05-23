using PrescriptionApp.Core.Entities;
using PrescriptionApp.Core.Interfaces;

namespace PrescriptionApp.Services
{
    public class PrescriptionService : IPrescriptionService
    {
        private readonly IPrescriptionRepository _prescriptionRepository;

        public PrescriptionService(IPrescriptionRepository prescriptionRepository)
        {
            _prescriptionRepository = prescriptionRepository;
        }

        public async Task<Prescription> AddPrescriptionAsync(Prescription prescription)
        {
            return await _prescriptionRepository.AddPrescriptionAsync(prescription);
        }

        public async Task<Prescription> GetPrescriptionByIdAsync(int id)
        {
            throw new NotImplementedException("GetPrescriptionByIdAsync not implemented in repository");
        }

        public async Task<IEnumerable<Prescription>> GetPrescriptionsByPatientIdAsync(int patientId)
        {
            return await _prescriptionRepository.GetPrescriptionsByPatientIdAsync(patientId);
        }

        public async Task<IEnumerable<Prescription>> GetPrescriptionsByDoctorIdAsync(int doctorId)
        {
            throw new NotImplementedException("GetPrescriptionsByDoctorIdAsync not implemented in repository");
        }
    }
}