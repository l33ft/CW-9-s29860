using System.ComponentModel.DataAnnotations;

namespace PrescriptionApp.API.DTOs;

public class AddPrescriptionDto
{
    [Required]
    public PatientDto Patient { get; set; } = null!;
    
    [Required]
    public List<MedicamentDto> Medicaments { get; set; } = new();
    
    [Required]
    public DateTime Date { get; set; }
    
    [Required]
    public DateTime DueDate { get; set; }
    
    [Required]
    public int IdDoctor { get; set; }
}