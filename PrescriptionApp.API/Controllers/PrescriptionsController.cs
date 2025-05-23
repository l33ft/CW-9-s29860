using Microsoft.AspNetCore.Mvc;
using PrescriptionApp.API.DTOs;
using PrescriptionApp.Core.Entities;
using PrescriptionApp.Core.Interfaces;

namespace PrescriptionApp.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PrescriptionsController : ControllerBase
{
    private readonly IPrescriptionService _prescriptionService;

    public PrescriptionsController(IPrescriptionService prescriptionService)
    {
        _prescriptionService = prescriptionService;
    }

    [HttpPost]
    public async Task<IActionResult> AddPrescription([FromBody] AddPrescriptionDto prescriptionDto)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var prescription = new Prescription
            {
                IdPatient = prescriptionDto.Patient.IdPatient ?? 0, 
                IdDoctor = prescriptionDto.IdDoctor,
                Date = prescriptionDto.Date,
                DueDate = prescriptionDto.DueDate
            };

            var result = await _prescriptionService.AddPrescriptionAsync(prescription);
            
            return Ok(new { Message = "Prescription added successfully", Prescription = result });
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new { Message = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { Message = "Internal server error", Details = ex.Message });
        }
    }
}