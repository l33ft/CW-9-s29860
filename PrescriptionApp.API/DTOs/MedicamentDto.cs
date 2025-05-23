using System.ComponentModel.DataAnnotations;

namespace PrescriptionApp.API.DTOs;

public class MedicamentDto
{
    [Required]
    public int IdMedicament { get; set; }
    
    [Required]
    [Range(1, int.MaxValue)]
    public int Dose { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Details { get; set; } = string.Empty;
}