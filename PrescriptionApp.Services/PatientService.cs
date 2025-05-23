using PrescriptionApp.Core.Entities;
using PrescriptionApp.Core.Interfaces;

namespace PrescriptionApp.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;

        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public async Task<Patient> GetPatientByIdAsync(int id)
        {
            return await _patientRepository.GetPatientByIdAsync(id);
        }

        public async Task<IEnumerable<Patient>> GetAllPatientsAsync()
        {
            throw new NotImplementedException("GetAllPatientsAsync not implemented in repository");
        }

        public async Task<Patient> CreatePatientAsync(Patient patient)
        {
            return await _patientRepository.AddPatientAsync(patient);
        }

        public async Task<Patient> UpdatePatientAsync(Patient patient)
        {
            throw new NotImplementedException("UpdatePatientAsync not implemented in repository");
        }

        public async Task<bool> DeletePatientAsync(int id)
        {
            throw new NotImplementedException("DeletePatientAsync not implemented in repository");
        }
        
        public async Task<Patient> GetPatientWithPrescriptionsAsync(int id)
        {
            return await _patientRepository.GetPatientWithPrescriptionsAsync(id);
        }
    }
}