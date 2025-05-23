using Microsoft.AspNetCore.Mvc;
using PrescriptionApp.Core.Interfaces;

namespace PrescriptionApp.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PatientsController : ControllerBase
{
    private readonly IPatientService _patientService;

    public PatientsController(IPatientService patientService)
    {
        _patientService = patientService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetPatient(int id)
    {
        try
        {
            var patient = await _patientService.GetPatientWithPrescriptionsAsync(id);
            
            if (patient == null)
            {
                return NotFound(new { Message = "Patient not found" });
            }

            return Ok(patient);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { Message = "Internal server error", Details = ex.Message });
        }
    }
}